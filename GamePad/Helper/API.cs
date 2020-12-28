using SharpDX.DirectInput;
using System;
using System.Collections.Generic;

namespace GamePad
{
    /// <summary>
    /// 获取手柄数据的API接口
    /// </summary>
    public class API
    {
        /// <summary>
        /// 按键按下的状态集合
        /// </summary>
        public bool[] Buttons { get; private set; } = new bool[] { };

        /// <summary>
        /// 方向键按下的对应数据
        /// </summary>
        public int[] PointOfView { get; private set; } = new int[] { };

        /// <summary>
        /// Acceleration Sliders 数据
        /// </summary>
        public int[] AccSliders { get; private set; } = new int[] { };

        /// <summary>
        /// Force Sliders 数据
        /// </summary>
        public int[] ForSliders { get; private set; } = new int[] { };

        /// <summary>
        /// Velocity Sliders 数据
        /// </summary>
        public int[] VelSliders { get; private set; } = new int[] { };

        /// <summary>
        /// Sliders 数据
        /// </summary>
        public int[] Sliders { get; private set; } = new int[] { };

        /// <summary>
        /// 平移轴 X轴的数据
        /// </summary>
        public int X { get; private set; }

        /// <summary>
        /// 平移轴 Y轴的数据
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// 平移轴 Z轴的数据
        /// </summary>
        public int Z { get; private set; }

        /// <summary>
        /// 旋转轴 X轴的数据
        /// </summary>
        public int RotationX { get; private set; }

        /// <summary>
        /// 旋转轴 Y轴的数据
        /// </summary>
        public int RotationY { get; private set; }

        /// <summary>
        /// 旋转轴 Z轴的数据
        /// </summary>
        public int RotationZ { get; private set; }

        /// <summary>
        /// 速度轴 X轴的数据
        /// </summary>
        public int VelocityX { get; private set; }

        /// <summary>
        /// 速度轴 Y轴的数据
        /// </summary>
        public int VelocityY { get; private set; }

        /// <summary>
        /// 速度轴 Z轴的数据
        /// </summary>
        public int VelocityZ { get; private set; }

        /// <summary>
        /// 角速度轴 X轴的数据
        /// </summary>
        public int AngularVelocityX { get; private set; }

        /// <summary>
        /// 角速度轴 Y轴的数据
        /// </summary>
        public int AngularVelocityY { get; private set; }

        /// <summary>
        /// 角速度轴 Z轴的数据
        /// </summary>
        public int AngularVelocityZ { get; private set; }

        /// <summary>
        /// 加速度轴 X轴的数据
        /// </summary>
        public int AccelerationX { get; private set; }

        /// <summary>
        /// 加速度轴 Y轴的数据
        /// </summary>
        public int AccelerationY { get; private set; }

        /// <summary>
        /// 加速度轴 Z轴的数据
        /// </summary>
        public int AccelerationZ { get; private set; }

        /// <summary>
        /// 角加速度轴 X轴的数据
        /// </summary>
        public int AngularAccelerationX { get; private set; }

        /// <summary>
        /// 角加速度轴 Y轴的数据
        /// </summary>
        public int AngularAccelerationY { get; private set; }

        /// <summary>
        /// 角加速度轴 Z轴的数据
        /// </summary>
        public int AngularAccelerationZ { get; private set; }

        /// <summary>
        /// 力量轴 X轴的数据
        /// </summary>
        public int ForceX { get; private set; }

        /// <summary>
        /// 力量轴 Y轴的数据
        /// </summary>
        public int ForceY { get; private set; }

        /// <summary>
        /// 力量轴 Z轴的数据
        /// </summary>
        public int ForceZ { get; private set; }

        /// <summary>
        /// 扭力轴 X轴的数据
        /// </summary>
        public int TorqueX { get; private set; }

        /// <summary>
        /// 扭力轴 Y轴的数据
        /// </summary>
        public int TorqueY { get; private set; }

        /// <summary>
        /// 扭力轴 Z轴的数据
        /// </summary>
        public int TorqueZ { get; private set; }

        /// <summary>
        /// 设置当前游戏手柄的数据值
        /// </summary>
        /// <param name="CurJoyState">当前手柄的状态对象</param>
        public void SetValue(JoystickState CurJoyState)
        {
            // 检查对象是否完成初始化
            bool Init = Buttons.Length <= 0;
            Init |= PointOfView.Length <= 0;
            Init |= AccSliders.Length <= 0;
            Init |= ForSliders.Length <= 0;
            Init |= VelSliders.Length <= 0;
            Init |= Sliders.Length <= 0;
            if (Init)
            {
                // 初始化按钮对象
                Buttons = CurJoyState.Buttons;

                // 初始化上下左右方向键的数据
                PointOfView = CurJoyState.PointOfViewControllers;

                // 初始化滑杆的数据
                AccSliders = CurJoyState.AccelerationSliders;
                ForSliders = CurJoyState.ForceSliders;
                VelSliders = CurJoyState.VelocitySliders;
                Sliders = CurJoyState.Sliders;
            }

            // 对按钮状态进行赋值操作
            int Len = Math.Min(CurJoyState.Buttons.Length, Buttons.Length);
            for (int i = 0; i < Len; i++) Buttons[i] = CurJoyState.Buttons[i];

            // 对上下左右方向键进行赋值操作
            Len = Math.Min(CurJoyState.PointOfViewControllers.Length, PointOfView.Length);
            for (int i = 0; i < Len; i++)
                PointOfView[i] = CurJoyState.PointOfViewControllers[i];

            // 对滑杆数据进行赋值操作
            Len = CurJoyState.Sliders.Length;
            for (int i = 0; i < Len; i++)
            {
                AccSliders[i] = CurJoyState.AccelerationSliders[i];
                ForSliders[i] = CurJoyState.ForceSliders[i];
                VelSliders[i] = CurJoyState.VelocitySliders[i];
                Sliders[i] = CurJoyState.Sliders[i];
            }

            // 对平移轴进行赋值
            X = CurJoyState.X;
            Y = CurJoyState.Y;
            Z = CurJoyState.Z;

            // 旋转轴进行赋值
            RotationX = CurJoyState.RotationX;
            RotationY = CurJoyState.RotationY;
            RotationZ = CurJoyState.RotationZ;

            // 对速度轴进行赋值
            VelocityX = CurJoyState.VelocityX;
            VelocityY = CurJoyState.VelocityY;
            VelocityZ = CurJoyState.VelocityZ;

            // 对角速度轴进行赋值
            AngularVelocityX = CurJoyState.AngularVelocityX;
            AngularVelocityY = CurJoyState.AngularVelocityY;
            AngularVelocityZ = CurJoyState.AngularVelocityZ;

            // 对加速度轴进行赋值
            AccelerationX = CurJoyState.AccelerationX;
            AccelerationY = CurJoyState.AccelerationY;
            AccelerationZ = CurJoyState.AccelerationZ;

            // 对角加速度进行赋值
            AngularAccelerationX = CurJoyState.AngularAccelerationX;
            AngularAccelerationY = CurJoyState.AngularAccelerationY;
            AngularAccelerationZ = CurJoyState.AngularAccelerationZ;

            // 对力量轴进行赋值
            ForceX = CurJoyState.ForceX;
            ForceY = CurJoyState.ForceY;
            ForceZ = CurJoyState.ForceZ;

            // 对扭力轴进行赋值
            TorqueX = CurJoyState.TorqueX;
            TorqueY = CurJoyState.TorqueY;
            TorqueZ = CurJoyState.TorqueZ;
        }

        /// <summary>
        /// 获取当前电脑已连接的的游戏手柄的对象
        /// </summary>
        /// <returns>返回已连接的手柄对象集合</returns>
        public static List<Joystick> GetGampad()
        {
            List<Joystick> DeviceList = new List<Joystick> { };
            DirectInput DirInput = new DirectInput();
            foreach (DeviceInstance Item in DirInput.GetDevices())
            {
                if (DeviceType.Gamepad == Item.Type || DeviceType.Joystick == Item.Type)
                {
                    Joystick CurDevice = new Joystick(DirInput, Item.InstanceGuid);
                    CurDevice.Properties.AxisMode = DeviceAxisMode.Absolute;
                    CurDevice.Acquire();
                    DeviceList.Add(CurDevice);
                }
            }
            return DeviceList;
        }
    }
}
