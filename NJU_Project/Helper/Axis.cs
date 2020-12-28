using Library;

namespace NJU_Project
{
    public class Axis
    {
        /// <summary>
        /// 指示当前轴对应的索引
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// 当前对象的LT或RT状态
        /// </summary>
        public bool T_Button 
        {
            get
            {
                // 获取当前按下的运行模式按键
                if (Bindslider == Slider.LX || Bindslider == Slider.LY)
                    return PadDevice.LT;
                else return PadDevice.RT;
            }
        }


        /// <summary>
        /// 当前对象的LB或RB状态
        /// </summary>
        public bool B_Button
        {
            get
            {
                // 获取当前按下的运行模式按键
                if (Bindslider == Slider.LX || Bindslider == Slider.LY)
                    return PadDevice.LB;
                else return PadDevice.RB;
            }
        }

        /// <summary>
        /// 指示当前轴是否被选中
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// 指示当前轴的控制是否反转
        /// </summary>
        public bool Axis_Rev { get; set; } = false;

        /// <summary>
        /// 当前轴的移动速度
        /// </summary>
        public int[] SpeedArray { get; } = new int[4];

        /// <summary>
        /// 初始化当前轴的对象
        /// </summary>
        /// <param name="PadDevice">手柄对象</param>
        /// <param name="MTDevice">控制的电机设备对象</param>
        /// <param name="Index">当前轴对应的电机索引</param>
        /// <param name="Bindslider">当前轴绑定的摇杆对象</param>
        public Axis(GamePad.Core PadDevice, MTDevice.Core MTDevice, int Index, Slider Bindslider) 
        {
            this.PadDevice = PadDevice;
            this.MTDevice = MTDevice;
            this.Index = Index;
            this.Bindslider = Bindslider;
            Load();
        }

        /// <summary>
        /// 从本地配置文件中读取数据
        /// </summary>
        public void Load()
        {
            string Section = "Axis-" + Index.ToString();
            Axis_Rev = LoadConfig.LoadValue(Program.INIFile, Section, "Rev", -1) > 0;
            for (int i = 0; i < SpeedArray.Length; i++)
            {
                string Key = "Speed_" + i.ToString();
                SpeedArray[i] = LoadConfig.LoadValue(Program.INIFile, Section,Key, 1000);
            }
        }

        /// <summary>
        /// 当前轴绑定的摇杆对象
        /// </summary>
        public enum Slider
        {
            /// <summary>
            /// 对应LX摇杆
            /// </summary>
            LX,

            /// <summary>
            /// 对应LY摇杆
            /// </summary>
            LY,

            /// <summary>
            /// 对应RX摇杆
            /// </summary>
            RX,

            /// <summary>
            /// 对应RY摇杆
            /// </summary>
            RY
        }

        /// <summary>
        /// 当前电机绑定的摇杆对象
        /// </summary>
        public Slider Bindslider { get; }

        /// <summary>
        /// 当前控制的手柄对象
        /// </summary>
        public GamePad.Core PadDevice { get; }

        /// <summary>
        /// 控制的设备对象
        /// </summary>
        public MTDevice.Core MTDevice { get; }

        /// <summary>
        /// 移动当前轴对象
        /// </summary>
        /// <param name="Danger">是否危险移动标志, 如果是, 则只能慢速</param>
        public void Move(ref int WaitCount, bool Danger = false)
        {
            // 计算当前的速度
            double Value;
            switch (Bindslider)
            {
                case Slider.LX:
                    Value = PadDevice.LX;
                    break;
                case Slider.LY:
                    Value = PadDevice.LY;
                    break;
                case Slider.RX:
                    Value = PadDevice.RX;
                    break;
                case Slider.RY:
                    Value = PadDevice.RY;
                    break;
                default:
                    Value = 0;
                    break;
            }

            // 根据按键按下的情况返回速度数据
            if (!Danger)
            {
                if (T_Button && B_Button) Value *= SpeedArray[3];
                else if (T_Button && !B_Button) Value *= SpeedArray[2];
                else if (!T_Button && B_Button) Value *= SpeedArray[1];
                else Value *= SpeedArray[0];
            }
            else Value *= SpeedArray[0];

            // 设备索引越界检查
            if (Index < 0 || Index >= MTDevice.Axises.Length) return;
            if (MTDevice.Axises[Index] is null) return;

            // 输出具体速度值
            int TargetSpeed = (int)Value;
            if (Axis_Rev) TargetSpeed = -TargetSpeed;
            WaitCount = TargetSpeed == 0 ? WaitCount + 1 : 0;
            if (TargetSpeed == 0 && MTDevice.Axises[Index].Velocity != 0)
                MTDevice.Axises[Index].Stop_Run();
            else if (TargetSpeed != 0 && MTDevice.Axises[Index].Velocity != TargetSpeed)
                MTDevice.Axises[Index].Start_Run(TargetSpeed);
        }

    }
}
