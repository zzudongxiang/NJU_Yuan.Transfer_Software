using SharpDX.DirectInput;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace GamePad
{
    /// <summary>
    /// 获取手柄数据的核心按键操作
    /// </summary>
    public class Core
    {
        /// <summary>
        /// 当前的手柄对象
        /// </summary>
        public API GamePadAPI { get; set; } = new API();

        /// <summary>
        /// 显示当前连接的手柄名称
        /// </summary>
        public string Name { get; private set; } = string.Empty;

        /// <summary>
        /// 显示手柄连接状态
        /// </summary>
        public bool Status { get; private set; } = false;

        /// <summary>
        /// 被动获取手柄数据的后台进程
        /// </summary>
        private BackgroundWorker Worker { get; set; } = new BackgroundWorker();

        /// <summary>
        /// 构造对象时自动挂载后台线程
        /// </summary>
        public Core()
        {
            // 给后台被动获取按键数据添加对象
            Worker.WorkerSupportsCancellation = true;
            Worker.DoWork += Worker_DoWork;

            // 获取设备列表, 并使用得到的第一个设备
            List<Joystick> DeviceList = API.GetGampad();
            if (DeviceList.Count > 0)
            {
                Joystick CurrDevice = DeviceList.First();
                Worker.RunWorkerAsync(CurrDevice);
            }
            else Worker.RunWorkerAsync(null);
        }

        /// <summary>
        /// 后台现场进行的操作
        /// </summary>
        /// <param name="sender">传入的进程对象</param>
        /// <param name="e">传入的进程参数</param>
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 如果没有传入Joystick对象, 则创建新的对象
            Joystick CurrDevice = null;
            if (e.Argument is null || !(e.Argument is Joystick))
            {
                List<Joystick> DeviceList;
                while (!Worker.CancellationPending)
                {
                    DeviceList = API.GetGampad();
                    if (DeviceList.Count > 0)
                    {
                        CurrDevice = DeviceList.First();
                        break;
                    }
                    else Thread.Sleep(1000);
                }
            }
            else CurrDevice = e.Argument as Joystick;
            Status = true;
            Name = CurrDevice.Information.ProductName;

            // 开始后台服务进程
            while (!Worker.CancellationPending)
            {
                try
                {
                    // 尝试读取手柄数据, 如果读取失败则视为手柄连接已断开
                    GamePadAPI.SetValue(CurrDevice.GetCurrentState());
                    Thread.Sleep(10);
                }
                catch
                {
                    Status = false;
                    Name = string.Empty;
                    while (!Worker.CancellationPending)
                    {
                        try
                        {
                            // 否则尝试重新连接, 直到连接成功为止
                            CurrDevice.Acquire();
                            Status = true;
                            Name = CurrDevice.Information.ProductName;
                            break;
                        }
                        catch
                        {
                            Thread.Sleep(1000);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 从本地配置文件中加载关联的按键对象
        /// </summary>
        public void Load()
        {
            // 重新装载ABXY组按键的属性
            _A.Load();
            _B.Load();
            _X.Load();
            _Y.Load();

            // 重新装载Up, Down, Left, Right组按键的属性
            _POV.Load();

            // 重新装载LT, LB, RT, RB组的按键属性
            _LT.Load();
            _LB.Load();
            _RT.Load();
            _RB.Load();

            // 重新装载摇杆的属性
            _LX.Load();
            _LY.Load();
            _RX.Load();
            _RY.Load();
        }

        #region 按键对象

        /// <summary>
        /// 按键A对应的对象
        /// </summary>
        public PadButton _A { get; } = new PadButton("A");

        /// <summary>
        /// 按键B对应的对象
        /// </summary>
        public PadButton _B { get; } = new PadButton("B");

        /// <summary>
        /// 按键X对应的对象
        /// </summary>
        public PadButton _X { get; } = new PadButton("X");

        /// <summary>
        /// 按键Y对应的对象
        /// </summary>
        public PadButton _Y { get; } = new PadButton("Y");

        /// <summary>
        /// 按键LT对应的对象
        /// </summary>
        public PadButton _LT { get; } = new PadButton("LT");

        /// <summary>
        /// 按键LB对应的对象
        /// </summary>
        public PadButton _LB { get; } = new PadButton("LB");

        /// <summary>
        /// 按键RT对应的对象
        /// </summary>
        public PadButton _RT { get; } = new PadButton("RT");

        /// <summary>
        /// 按键RB对应的对象
        /// </summary>
        public PadButton _RB { get; } = new PadButton("RB");

        /// <summary>
        /// LX关联的手柄按键对象
        /// </summary>
        public PadSlider _LX { get; set; } = new PadSlider("LX");

        /// <summary>
        /// LY关联的手柄按键对象
        /// </summary>
        public PadSlider _LY { get; set; } = new PadSlider("LY");

        /// <summary>
        /// RX关联的按键对象
        /// </summary>
        public PadSlider _RX { get; set; } = new PadSlider("RX");

        /// <summary>
        /// RY对应的关联对象
        /// </summary>
        public PadSlider _RY { get; set; } = new PadSlider("RY");

        /// <summary>
        /// POV对应的索引
        /// </summary>
        public PadPOV _POV { get; set; } = new PadPOV("POV");

        #endregion

        #region 左右摇杆部分

        /// <summary>
        /// 左摇杆的水平方向, 数据从-1到1
        /// </summary>
        public double LX
        {
            get
            {
                _LX.Value = (int)_LX.Slider.GetValue(GamePadAPI, null); 
                return _LX.Value;
            }
        }

        /// <summary>
        /// 左摇杆的竖直方向, 数据从-1到1
        /// </summary>
        public double LY
        {
            get
            {
                _LY.Value = (int)_LY.Slider.GetValue(GamePadAPI, null);
                return _LY.Value;
            }
        }

        /// <summary>
        /// 右摇杆的水平方向, 数据从-1到1
        /// </summary>
        public double RX
        {
            get
            {
                _RX.Value = (int)_RX.Slider.GetValue(GamePadAPI, null);
                return _RX.Value;
            }
        }

        /// <summary>
        /// 左摇杆的竖直方向, 数据从-1到1
        /// </summary>
        public double RY
        {
            get
            {
                _RY.Value = (int)_RY.Slider.GetValue(GamePadAPI, null);
                return _RY.Value;
            }
        }

        #endregion

        #region 上下左右的方向键

        /// <summary>
        /// 获取POV对应的按键是否按下
        /// </summary>
        /// <param name="Value1">第一个角度</param>
        /// <param name="Value2">第二个角度</param>
        /// <param name="Value3">第三个角度</param>
        /// <returns>返回按键是否按下</returns>
        private bool GetPOV(int Value1, int Value2, int Value3)
        {
            if (_POV.Index < GamePadAPI.PointOfView.Length)
            {
                int Value = GamePadAPI.PointOfView[_POV.Index];
                return Value == Value1 || Value == Value2 || Value == Value3;
            }
            else return false;
        }

        /// <summary>
        /// 对应手柄方向键的上键
        /// </summary>
        public bool Up { get { return GetPOV(0, 4500, 31500); } }

        /// <summary>
        /// 对应手柄方向键的下键
        /// </summary>
        public bool Down { get { return GetPOV(18000, 22500, 13500); } }

        /// <summary>
        /// 对应手柄方向键的左键
        /// </summary>
        public bool Left { get { return GetPOV(27000, 22500, 31500); } }

        /// <summary>
        /// 对应手柄方向键的右键
        /// </summary>
        public bool Right { get { return GetPOV(9000, 4500, 13500); } }

        #endregion

        #region 按键点击部分

        /// <summary>
        /// 游戏手柄的A按键
        /// </summary>
        public bool A 
        { 
            get 
            {
                if (_A.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_A.Index];
                else return false;
            } 
        }

        /// <summary>
        /// 游戏手柄的B按键
        /// </summary>
        public bool B
        {
            get
            {
                if (_B.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_B.Index];
                else return false;
            }
        }

        /// <summary>
        /// 游戏手柄的X按键
        /// </summary>
        public bool X
        {
            get
            {
                if (_X.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_X.Index];
                else return false;
            }
        }

        /// <summary>
        /// 游戏手柄的Y按键
        /// </summary>
        public bool Y
        {
            get
            {
                if (_Y.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_Y.Index];
                else return false;
            }
        }

        /// <summary>
        /// 游戏手柄的LT按键
        /// </summary>
        public bool LT
        {
            get
            {
                if (_LT.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_LT.Index];
                else return false;
            }
        }

        /// <summary>
        /// 游戏手柄的LB按键
        /// </summary>
        public bool LB
        {
            get
            {
                if (_LB.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_LB.Index];
                else return false;
            }
        }

        /// <summary>
        /// 手柄上的RT按键
        /// </summary>
        public bool RT
        {
            get
            {
                if (_RT.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_RT.Index];
                else return false;
            }
        }

        /// <summary>
        /// 手柄上的RB按键
        /// </summary>
        public bool RB
        {
            get
            {
                if (_RB.Index < GamePadAPI.Buttons.Length)
                    return GamePadAPI.Buttons[_RB.Index];
                else return false;
            }
        }

        #endregion

    }
}
