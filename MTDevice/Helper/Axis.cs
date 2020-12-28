using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Threading;
namespace MTDevice
{
    /// <summary>
    /// 储存每个轴的相关属性对象
    /// </summary>
    public class Axis
    {
        
        /// <summary>
        /// 当前轴的别名
        /// </summary>
        public string Caption { get; private set; } = string.Empty;

        /// <summary>
        /// 当前轴的索引序号, 轴索引应该大于等于0
        /// </summary>
        public ushort Index { get; } 

        /// <summary>
        /// 后台读取轴状态的进程
        /// </summary>
        private BackgroundWorker Worker { get; set; } = new BackgroundWorker();

        /// <summary>
        /// 当前轴是否正在运动
        /// </summary>
        public bool isRun { get; private set; } = false;

        /// <summary>
        /// 当前轴是否到达负限位
        /// </summary>
        public bool isNeg { get; private set; } = false;

        /// <summary>
        /// 当前轴是否到达正限位
        /// </summary>
        public bool isPos { get; private set; } = false;

        /// <summary>
        /// 当前轴是否到达零限位
        /// </summary>
        public bool isZero { get; private set; } = false;

        /// <summary>
        /// 该轴移动的默认速度
        /// </summary>
        public int Speed { get; private set; } = 1000;

        /// <summary>
        /// 当前轴的加速度值
        /// </summary>
        public int Acc { get; private set; } = 1000;

        /// <summary>
        /// 当前轴的减速度值
        /// </summary>
        public int Decc { get; private set; } = 1000;

        /// <summary>
        /// 是否使用正限位作为零点位置
        /// </summary>
        public int ZeroHome { get; private set; } = -1;

        /// <summary>
        /// 当前轴对应的速度值(Hz/S)
        /// </summary>
        public int Velocity { get; private set; } = 0;

        /// <summary>
        /// 当前轴对应的软件位置数据
        /// </summary>
        public int Position { get; private set; } = 0;

        /// <summary>
        /// 当前轴的零点位置
        /// </summary>
        public int ZeroPosition { get; private set; } = 0;

        /// <summary>
        /// 智能复位的后台线程
        /// </summary>
        private BackgroundWorker AutoHomeWorker { get; } = new BackgroundWorker() { WorkerSupportsCancellation = true };

        /// <summary>
        /// 指示当前轴是否正在忙碌
        /// </summary>
        public bool IsBusy { get { return isRun; } } 

        /// <summary>
        /// 初始化轴的对象, 配置相关轴的信息
        /// </summary>
        /// <param name="Index"></param>
        public Axis(ushort Index)
        {
            this.Index = Index;
            AutoHomeWorker.DoWork += AutoHomeWorker_DoWork;
            Worker.DoWork += Worker_DoWork;
            Load();
        }

        /// <summary>
        /// 后台读取轴的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 提前申请空间, 等待处理数据
            int Result;
            byte isRun = 0;
            byte tmpDir = 0;
            byte isNeg = 0;
            byte isPos = 0;
            byte isZero = 0;
            byte tmpMode = 0;
            int Velocity = 0;
            int Position = 0;

            // 开始处理程序
            while (true)
            {
                try
                {
                    // 先读取状态, 并更新到类的信息上
                    Result = API.MT_Get_Axis_Status(Index, ref isRun, ref tmpDir, ref isNeg, ref isPos, ref isZero, ref tmpMode);
                    if (Result == 0)
                    {
                        this.isRun = isRun == 1;
                        this.isNeg = isNeg == 1;
                        this.isPos = isPos == 1;
                        this.isZero = isZero == 1;
                    }
                    else this.isRun = this.isNeg = this.isPos = this.isZero = false;


                    // 更新速度与位置信息
                    Result = API.MT_Get_Axis_V_Now(Index, ref Velocity);
                    this.Velocity = Result == 0 ? Velocity : 0;

                    // 更新速度与位置信息
                    Result = API.MT_Get_Axis_Software_P_Now(Index, ref Position);
                    this.Position = Result == 0 ? Position : 0;

                    // 定时刷新下一次的数据
                    Thread.Sleep(10);

                    // 如果当前状态已经不在运行中, 则自动停止刷新数据
                    if (!this.isRun) break;

                }
                catch { break; }
            }
        }

        /// <summary>
        /// 装载轴体的参数信息
        /// </summary>
        public void Load()
        {
            int Value;
            string Key = "Axis-" + Index.ToString();

            // 设置加速度
            Value = Library.LoadConfig.LoadValue(Program.INIFile, Key, "Acc", 1000);
            if (Value != Acc)
            {
                Acc = Value;
                API.MT_Set_Axis_Velocity_Acc(Index, Acc);
                API.MT_Set_Axis_Position_Acc(Index, Acc);
                API.MT_Set_Axis_Home_Acc(Index, Acc);
            }

            // 设置减速度
            Value = Library.LoadConfig.LoadValue(Program.INIFile, Key, "Decc", 1000); 
            if (Value != Decc)
            {
                Decc = Value;
                API.MT_Set_Axis_Velocity_Dec(Index, Decc);
                API.MT_Set_Axis_Position_Dec(Index, Decc);
                API.MT_Set_Axis_Home_Dec(Index, Decc);
            }

            // 读取轴的别名, 默认运行速度, 初始位与复位方向
            Caption = Program.INIFile.GetValue(Key, "Caption", "");
            Speed = Library.LoadConfig.LoadValue(Program.INIFile, Key, "Speed", 1000); 
            ZeroPosition = Library.LoadConfig.LoadValue(Program.INIFile, Key, "ZeroPosition", 1000); 
            ZeroHome = Library.LoadConfig.LoadValue(Program.INIFile, Key, "ZeroHome", -1); 

            // 更新数据
            if (!Worker.IsBusy) Worker.RunWorkerAsync();
        }

        /// <summary>
        /// 使当前轴按照指定速度开始运动
        /// </summary>
        /// <param name="Speed">指定的速度(可正可负)</param>
        /// <returns>返回指令是否发送成功</returns>
        public bool Start_Run(int Speed)
        {
            // 执行命令
            int Result = 0;
            Result += API.MT_Set_Axis_Mode_Velocity(Index);
            Result += API.MT_Set_Axis_Velocity_V_Target_Abs(Index, Speed);

            // 更新数据, 并返回结果
            if (Result == 0)
            {
                if (!Worker.IsBusy) Worker.RunWorkerAsync();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// 停止当前轴按照指定速度开始运动, 电机会减速到停止
        /// </summary>
        /// <returns>返回指令是否发送成功</returns>
        public bool Stop_Run()
        {
            // 更新数据, 并返回结果
            if (API.MT_Set_Axis_Velocity_Stop(Index) == 0)
            {
                if (!Worker.IsBusy) Worker.RunWorkerAsync();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// 将轴移动到指定位置
        /// </summary>
        /// <param name="Position">要移动到的位置</param>
        /// <returns>返回是否执行成功</returns>
        public bool Run(int Position)
        {
            // 执行命令
            int Result = 0;
            Result += API.MT_Set_Axis_Mode_Position_Open(Index);
            Result += API.MT_Set_Axis_Position_V_Max(Index, Speed);
            Result += API.MT_Set_Axis_Position_P_Target_Abs(Index, Position);

            // 开启数据刷新
            if (!Worker.IsBusy)
                Worker.RunWorkerAsync();

            // 返回结果
            return Result == 0;
        }

        /// <summary>
        /// 将当前轴运动到正限位或负限位处
        /// </summary>
        /// <returns>返回指令是否发送成功</returns>
        public bool Home()
        {
            // 计算复位的方向
            int HomeSpeed = Speed;
            if (ZeroHome > 0) HomeSpeed = Math.Abs(HomeSpeed);
            else HomeSpeed = -Math.Abs(HomeSpeed);

            // 执行命令
            int Result = 0;
            Result += API.MT_Set_Axis_Mode_Home_Home_Switch(Index);
            Result += API.MT_Set_Axis_Home_V(Index, HomeSpeed);

            // 更新数据, 并返回结果
            if (Result == 0)
            {
                if (!Worker.IsBusy) Worker.RunWorkerAsync();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// 自动复位, 先移动到限位处, 再移动到指定位置处
        /// </summary>
        /// <param name="Speed"></param>
        public void AutoHome()
        {
            if (IsBusy) return;
            if (!AutoHomeWorker.IsBusy) AutoHomeWorker.RunWorkerAsync();
        }

        /// <summary>
        /// 智能复位操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoHomeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Home();
            //do { Thread.Sleep(10); } while (IsBusy);
            if (!AutoHomeWorker.CancellationPending)
            {
                // 如果初始位是0位, 则自动停止
                //if (ZeroPosition == 0) return;

                // 开启后台数据读取进程, 实时刷新当前数据
                if (Run(ZeroPosition) && !Worker.IsBusy)
                    Worker.RunWorkerAsync();

                // 等待命令执行完成
                do { Thread.Sleep(10); } while (IsBusy);
            }
        }

        /// <summary>
        /// 紧急停止当前轴的运动
        /// </summary>
        /// <returns>返回指令是否发送成功</returns>
        public bool Halt()
        {
            // 更新数据, 并返回结果
            AutoHomeWorker.CancelAsync();
            if (API.MT_Set_Axis_Halt(Index) == 0)
            {
                if (!Worker.IsBusy) Worker.RunWorkerAsync();
                return true;
            }
            else return false;
        }
    }
}
