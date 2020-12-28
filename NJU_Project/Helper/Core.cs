using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace NJU_Project
{
    /// <summary>
    /// 将手柄与平移台关联的对象
    /// </summary>
    public class Core
    {
        /// <summary>
        /// 调用手柄操作的对象
        /// </summary>
        public GamePad.Core PadDevice { get; } = new GamePad.Core();

        /// <summary>
        /// 调用平移台设备的操作对象
        /// </summary>
        public MTDevice.Core MTDevice { get; } = new MTDevice.Core();

        /// <summary>
        /// 后台手柄扫描程序的对象
        /// </summary>
        private BackgroundWorker Worker { get; } = new BackgroundWorker() { WorkerSupportsCancellation = true };

        #region 定义各个轴电机对应的索引序号

        /// <summary>
        /// 定义A组X轴电机
        /// </summary>
        public Axis _GroupA_X { get; }

        /// <summary>
        /// 定义A组Y轴电机
        /// </summary>
        public Axis _GroupA_Y { get; }

        /// <summary>
        /// 定义A组Z轴电机
        /// </summary>
        public Axis _GroupA_Z { get; }

        /// <summary>
        /// 定义B组的X轴电机
        /// </summary>
        public Axis _GroupB_X { get; }

        /// <summary>
        /// 定义B组的Y轴电机
        /// </summary>
        public Axis _GroupB_Y { get; }

        /// <summary>
        /// 定义B组的Z轴电机
        /// </summary>
        public Axis _GroupB_Z { get; }

        /// <summary>
        /// 定义X轴方向倾斜电机
        /// </summary>
        public Axis _Rotation_X { get; }

        /// <summary>
        /// 定义Y轴方向倾斜电机
        /// </summary>
        public Axis _Rotation_Y { get; }

        /// <summary>
        /// 定义Z轴方向旋转电机
        /// </summary>
        public Axis _Rotation_Z { get; }


        #endregion

        #region 当前轴的工作模式

        /// <summary>
        /// 定义可选的工作模式
        /// </summary>
        public enum Mode
        {
            /// <summary>
            /// 悬空模式, 不做任何输入操作
            /// </summary>
            None,

            /// <summary>
            /// 单轴运动模式
            /// </summary>
            AxisMove,

            /// <summary>
            /// 两组自由旋转组
            /// </summary>
            Rotation,

            /// <summary>
            /// 仅控制A组XY方向
            /// </summary>
            GroupA_XY,

            /// <summary>
            /// 仅控制B组XY方向
            /// </summary>
            GroupB_XY,

            /// <summary>
            /// 仅控制A组Z轴方向
            /// </summary>
            GroupA_Z,

            /// <summary>
            /// 仅控制B组Z轴方向
            /// </summary>
            GroupB_Z,

            /// <summary>
            /// XY轴同步移动
            /// </summary>
            MoveXY_Sync,

            /// <summary>
            /// Z轴同步移动
            /// </summary>
            MoveZ_Sync,

        }

        /// <summary>
        /// 当前的工作模式
        /// </summary>
        public Mode WorkMode { get; set; } = Mode.None;

        /// <summary>
        /// 记录上一次的工作模式
        /// </summary>
        private Mode LastMode { get; set; } = Mode.None;

        /// <summary>
        /// 单轴运动模式下的轴序号
        /// </summary>
        public int CurrentAxis 
        {
            get 
            {
                if (_CurrentAxis is null) return -1;
                else return _CurrentAxis.Index;
            }
            set
            {
                if (CurrentAxis != value)
                {
                    WorkMode = Mode.AxisMove;
                    ClearSelect();
                    foreach (PropertyInfo Item in typeof(Core).GetProperties())
                    {
                        object Value = Item.GetValue(this, null);
                        if (Value is Axis AxisValue && AxisValue.Index == value)
                        {
                            AxisValue.Selected = true;
                            _CurrentAxis = AxisValue;
                            return;
                        }
                    }
                    _CurrentAxis = null;
                    return;
                }
            }
        }

        /// <summary>
        /// 单轴运动模式下的轴对象
        /// </summary>
        public Axis _CurrentAxis { get; set; } = null;

        #endregion

        /// <summary>
        /// 初始化对象
        /// </summary>
        public Core()
        {
            // 给各个轴初始化, 绑定关联的按键对象
            _GroupA_X = new Axis(PadDevice, MTDevice, 5, Axis.Slider.RX);
            _GroupA_Y = new Axis(PadDevice, MTDevice, 6, Axis.Slider.RY);
            _GroupA_Z = new Axis(PadDevice, MTDevice, 4, Axis.Slider.LY);

            _GroupB_X = new Axis(PadDevice, MTDevice, 2, Axis.Slider.RX);
            _GroupB_Y = new Axis(PadDevice, MTDevice, 1, Axis.Slider.RY);
            _GroupB_Z = new Axis(PadDevice, MTDevice, 0, Axis.Slider.LY);

            _Rotation_X = new Axis(PadDevice, MTDevice, 7, Axis.Slider.RX);
            _Rotation_Y = new Axis(PadDevice, MTDevice, 8, Axis.Slider.RY);
            _Rotation_Z = new Axis(PadDevice, MTDevice, 3, Axis.Slider.LX);

            // 开启后台线程监听按键按下
            Worker.DoWork += Worker_DoWork;
            Worker.RunWorkerAsync();
        }

        /// <summary>
        /// 从本地配置文件中装载文件数据
        /// </summary>
        public void Load()
        {
            // 从本地配置文件中加载相关的属性数值
            _GroupA_X.Load();
            _GroupA_Y.Load();
            _GroupA_Z.Load();

            _GroupB_X.Load();
            _GroupB_Y.Load();
            _GroupB_Z.Load();

            _Rotation_X.Load();
            _Rotation_Y.Load();
            _Rotation_Z.Load();
        }

        /// <summary>
        /// 当前所有轴是否有轴正忙
        /// </summary>
        public bool IsBusy
        {
            get
            {
                bool isRun = false;
                isRun |= MTDevice.Axises[_GroupA_X.Index].isRun;
                isRun |= MTDevice.Axises[_GroupA_Y.Index].isRun;
                isRun |= MTDevice.Axises[_GroupA_Z.Index].isRun;
                isRun |= MTDevice.Axises[_GroupB_X.Index].isRun;
                isRun |= MTDevice.Axises[_GroupB_Y.Index].isRun;
                isRun |= MTDevice.Axises[_GroupB_Z.Index].isRun;
                isRun |= MTDevice.Axises[_Rotation_X.Index].isRun;
                isRun |= MTDevice.Axises[_Rotation_Y.Index].isRun;
                isRun |= MTDevice.Axises[_Rotation_Z.Index].isRun;
                return isRun;
            }
        }

        /// <summary>
        /// 等待当前命令执行完毕
        /// </summary>
        private void WaitCommand(ref bool Halt)
        {
            do
            {
                HaltTest(ref Halt);
                Thread.Sleep(10);
            } while (!Worker.CancellationPending && IsBusy);
        }

        private int WaitCount = 0;

        /// <summary>
        /// 自动矫正零点
        /// </summary>
        /// <param name="Halt"></param>
        private void AutoHome(ref bool Halt)
        {
            if (MTDevice.Axises.Length <= 0) return;
            // 开机移动到初始位
            MTDevice.Axises[_GroupA_X.Index].Home();
            MTDevice.Axises[_GroupA_Y.Index].Home();
            MTDevice.Axises[_GroupA_Z.Index].Home();
            MTDevice.Axises[_GroupB_X.Index].Home();
            MTDevice.Axises[_GroupB_Y.Index].Home();
            MTDevice.Axises[_GroupB_Z.Index].Home();
            MTDevice.Axises[_Rotation_X.Index].Home();
            MTDevice.Axises[_Rotation_Y.Index].Home();
            MTDevice.Axises[_Rotation_Z.Index].Home();
            WaitCommand(ref Halt);
            if (!Worker.CancellationPending)
            {
                MTDevice.Axises[_GroupA_X.Index].AutoHome();
                MTDevice.Axises[_GroupA_Y.Index].AutoHome();
                MTDevice.Axises[_GroupA_Z.Index].AutoHome();
                MTDevice.Axises[_GroupB_X.Index].AutoHome();
                MTDevice.Axises[_GroupB_Y.Index].AutoHome();
                MTDevice.Axises[_GroupB_Z.Index].AutoHome();
                MTDevice.Axises[_Rotation_X.Index].AutoHome();
                MTDevice.Axises[_Rotation_Y.Index].AutoHome();
                MTDevice.Axises[_Rotation_Z.Index].AutoHome();
                WaitCommand(ref Halt);
            }
        }

        /// <summary>
        /// 后台处理线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool Halt = false;
            int tmpValue = 0;

            // 开始执行主程序
            while (!Worker.CancellationPending)
            {
                // 循环检测延迟
                Thread.Sleep(10);

                // 判断当前是否是急停状态
                if (HaltTest(ref Halt)) continue;

                // 判断是否长时间未操作
                if (WaitCount > 3000)
                {
                    WaitCount = 0;
                    WorkMode = Mode.None;
                    continue;
                }

                // 记录是否切换状态显示
                if (LastMode != WorkMode)
                {
                    LastMode = WorkMode;
                    ClearSelect();
                }

                // 判断当前是否是单轴移动模式
                if (AxisMove(ref WaitCount)) continue;


                // 判断当前是否是旋转模式
                if (RotationMove(ref WaitCount)) continue;

                // 其他移动模式判断
                if (WorkMode == Mode.GroupA_XY)
                {
                    _GroupA_X.Selected = _GroupA_Y.Selected = true;
                    tmpValue = 0;
                    _GroupA_X.Move(ref tmpValue);
                    _GroupA_Y.Move(ref tmpValue);
                    WaitCount = tmpValue > 0 ? WaitCount + 1 : 0;
                }
                else if (WorkMode == Mode.GroupB_XY)
                {
                    _GroupB_X.Selected = _GroupB_Y.Selected = true;
                    tmpValue = 0;
                    _GroupB_X.Move(ref tmpValue);
                    _GroupB_Y.Move(ref tmpValue);
                    WaitCount = tmpValue > 0 ? WaitCount + 1 : 0;
                }
                else if (WorkMode == Mode.GroupA_Z)
                {
                    _GroupA_Z.Selected = true;
                    _GroupA_Z.Move(ref WaitCount);
                }
                else if (WorkMode == Mode.GroupB_Z)
                {
                    _GroupB_Z.Selected = true;
                    _GroupB_Z.Move(ref WaitCount);
                }
                else if (WorkMode == Mode.MoveXY_Sync)
                {
                    _GroupA_X.Selected = _GroupA_Y.Selected = true;
                    _GroupB_X.Selected = _GroupB_Y.Selected = true;
                    tmpValue = 0;
                    _GroupA_X.Move(ref tmpValue, true);
                    _GroupB_X.Move(ref tmpValue, true);
                    _GroupA_Y.Move(ref tmpValue, true);
                    _GroupB_Y.Move(ref tmpValue, true);
                    WaitCount = tmpValue > 0 ? WaitCount + 1 : 0;
                }
                else if (WorkMode == Mode.MoveZ_Sync)
                {
                    _GroupA_Z.Selected = _GroupB_Z.Selected = true;
                    tmpValue = 0;
                    _GroupA_Z.Move(ref tmpValue, true);
                    _GroupB_Z.Move(ref tmpValue, true);
                    WaitCount = tmpValue > 0 ? WaitCount + 1 : 0;
                }
            }
        }

        /// <summary>
        /// 清除所有轴的选中状态
        /// </summary>
        private void ClearSelect()
        {
            _GroupA_X.Selected = _GroupA_Y.Selected = _GroupA_Z.Selected = false;
            _GroupB_X.Selected = _GroupB_Y.Selected = _GroupB_Z.Selected = false;
            _Rotation_X.Selected = _Rotation_Y.Selected = _Rotation_Z.Selected = false;
        }

        /// <summary>
        /// 判断当前是否不再继续执行下面的操作
        /// </summary>
        /// <returns>返回true则停止执行</returns>
        private bool HaltTest(ref bool Halt)
        {
            // 判断当前是否是急停状态
            if (!Halt && PadDevice.LB && PadDevice.RB && PadDevice.B)
            {
                // LB + RB + B三键同时按下认为是急停操作
                Halt = true;
                MTDevice.HaltAll();
                return true;
            }
            else Halt = false;

            // 判断是否是悬空模式
            if (WorkMode == Mode.None)
            {
                ClearSelect();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// 单轴移动模式, 返回是否处于当前模式
        /// </summary>
        /// <returns></returns>
        private bool AxisMove(ref int WaitCount)
        {
            // 判断是否是单轴移动模式
            if (WorkMode == Mode.AxisMove)
            {
                // 判断当前是否选择了要控制的轴对象
                if (!(_CurrentAxis is null))
                {
                    _CurrentAxis.Move(ref WaitCount);
                    return true;
                }
                else WorkMode = Mode.None;
            }
            return false;
        }

        /// <summary>
        /// 判断当前是否是旋转模式
        /// </summary>
        /// <returns>如果是, 则控制移动, 并返回true</returns>
        private bool RotationMove(ref int WaitCount)
        {
            // 判断是否是悬空模式
            if (WorkMode == Mode.Rotation)
            {
                _Rotation_X.Selected = _Rotation_Y.Selected = _Rotation_Z.Selected = true;
                int tmpValue = 0;
                _Rotation_X.Move(ref tmpValue);
                _Rotation_Y.Move(ref tmpValue);
                _Rotation_Z.Move(ref tmpValue);
                WaitCount = tmpValue > 0 ? WaitCount + 1 : 0;
                return true;
            }
            return false;
        }
    }
}
