using System.Runtime.InteropServices;

namespace MTDevice
{
    /// <summary>
    /// 调用电机的API接口
    /// </summary>
    public static class API
    {
        #region 初始化与释放资源部分

        /// <summary>
        /// 创建Dll 工作需要的资源，在使用其它函数前必须调用本函数，一般放在软件的初始化部分执行
        /// </summary>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Init();

        /// <summary>
        /// 释放Dll工作需要的资源，在软件退出时执行
        /// </summary>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_DeInit();

        #endregion

        #region 设备的通信端口

        /// <summary>
        /// 打开USB 通信口，在需要通过USB 和板卡通信前调用
        /// 函数执行成功不代表USB 已经能工作，只是完成了相关的通信初始化工作
        /// </summary>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Open_USB();

        /// <summary>
        /// 关闭USB 通信口，在需要切换通信端口或者退出软件时调用
        /// </summary>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Close_USB();

        /// <summary>
        /// 在通信端口打开以后，检测是否存在MT系列运动控制板卡
        /// </summary>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Check();

        #endregion

        # region 转移台的硬件信息获取

        /// <summary>
        /// 读取板卡的型号。已了解无需调用本函数。也可通过官方工具来查看
        /// </summary>
        /// <param name="sID">16 长度的字符缓冲区</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Product_ID(ref int sID);

        /// <summary>
        /// 读取板卡固件的版本号
        /// </summary>
        /// <param name="pMajor">大版本号</param>
        /// <param name="pMinor">小版本号</param>
        /// <param name="pRelease">发布次数</param>
        /// <param name="pBuild">编译次数</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Product_Version2(ref int pMajor, ref int pMinor, ref int pRelease, ref int pBuild);

        #endregion

        #region 轴体归零的相关操作

        /// <summary>
        /// 设置指定的轴为开环零位模式，查找零位以零位开关和限位开关为判断依据
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Mode_Home_Home_Switch(ushort AObj);

        /// <summary>
        /// 设置指定轴以指定速度查找零位，速度值为正，则正向查找零位，速度为负，则负向查找零位
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的查找零位速度(Hz/S)可正可负</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Home_V(ushort AObj, int Value);

        /// <summary>
        /// 停止指定轴的零位运动模式
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Home_Stop(ushort AObj);

        /// <summary>
        /// 设置指定轴的零位模式启动初始速度，默认为50Hz/s,一般无需修改
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的启动速度(Hz/S)只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Home_V_Start(ushort AObj, int Value);

        /// <summary>
        /// 设置指定轴的零位模式的加速度值，默认为500Hz/s²
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的加速度(Hz/S²)只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Home_Acc(ushort AObj, int Value);

        /// <summary>
        /// 设置指定轴的零位模式的减速度值，默认为500Hz/s²
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的减速度(Hz/S²)只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Home_Dec(ushort AObj, int Value);

        /// <summary>
        /// 读取指定控制轴零位模式的加速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前加速度Hz/S²</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Home_Acc(ushort AObj, ref int Value);

        /// <summary>
        /// 读取指定控制轴零位模式的减速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前减速度Hz/S²</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Home_Decc(ushort AObj, ref int Value);

        #endregion

        #region 速度模式的设置操作

        /// <summary>
        /// 设置指定的轴为速度模式
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Mode_Velocity(ushort AObj);

        /// <summary>
        /// 读取速度模式下的目标速度
        /// </summary>
        /// <param name="AObj">指定轴的目标速度(Hz/S)</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Axis_Velocity_V_Target(ushort AObj, ref int Value);

        /// <summary>
        /// 设置速度模式下的绝对目标速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的绝对目标速度(Hz/S)可正可负</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Velocity_V_Target_Abs(ushort AObj, int Value);

        /// <summary>
        /// 设置速度模式下的相对当前速度的相对速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的相对当前速度的速度(Hz/S)可正可负</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Velocity_V_Target_Rel(ushort AObj, int Value);

        /// <summary>
        /// 停止指定轴的速度运动模式
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Velocity_Stop(ushort AObj);

        /// <summary>
        /// 设置指定轴的速度模式启动初始速度，默认为50Hz/s, 一般无需修改
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的启动速度(Hz/S)只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Velocity_V_Start(ushort AObj, int Value);

        /// <summary>
        /// 设置指定轴的速度模式的加速度值，默认为500Hz/s²
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的加速度Hz/S²只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Velocity_Acc(ushort AObj, int Value);

        /// <summary>
        /// 设置指定轴的速度模式的减速度值，默认为500Hz/s²
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的减速度Hz/S²只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Velocity_Dec(ushort AObj, int Value);

        /// <summary>
        /// 读取指定控制轴速度模式的加速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前加速度 Hz/S²</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Velocity_Acc(ushort AObj, ref int Value);

        /// <summary>
        /// 读取指定控制轴速度模式的减速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前减速度 Hz/S²</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Velocity_Decc(ushort AObj, ref int Value);

        #endregion

        #region 电机通用相关函数

        /// <summary>
        /// 读取板卡的电机控制轴数
        /// </summary>
        /// <param name="Value">板卡支持的电机控制的数量0‐N</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Axis_Num(ref int Value);

        /// <summary>
        /// 读取板卡指定的工作模式
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">
        /// 板卡指定轴的当前工作模式
        /// 0: 零位模式
        /// 1: 速度模式
        /// 2：位置模式（默认）
        /// 3：直线插补
        /// 4：圆弧插补
        /// </param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Axis_Mode(ushort AObj, ref int Value);

        /// <summary>
        /// 读取指定控制轴当前的速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前速度 Hz/S</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Axis_V_Now(ushort AObj, ref int Value);

        /// <summary>
        /// 读取指定控制轴当前的软件位置
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前软件位置, 单位为步数</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Axis_Software_P_Now(ushort AObj, ref int Value);

        /// <summary>
        /// 设置指定控制轴当前的软件位置
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的当前软件位置, 单位为步数</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Software_P(ushort AObj, int Value);

        /// <summary>
        /// 读取指定控制轴当前的状态
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Run">指定轴的当前运动状态，1 为运动，0 为不运动</param>
        /// <param name="Dir">指定轴当前的方向，1 为正方向，0 为负方向</param>
        /// <param name="Neg">指定轴当前的负限位,1 为负限位有效，0 为负限位无效</param>
        /// <param name="Pos">指定轴当前的正限位,1 为正限位有效，0 为正限位无效</param>
        /// <param name="Zero">指定轴当前的零位,1 为零位有效，0 为零位无效</param>
        /// <param name="Mode">指定轴当前的模式</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Get_Axis_Status(ushort AObj, ref byte Run, ref byte Dir, ref byte Neg, ref byte Pos, ref byte Zero, ref byte Mode);

        /// <summary>
        /// 立即停止指定轴的运动，没有减速过程，对所有运动模式有效
        /// 紧急停止惯性较大的运动体时会对驱动器造成一定的冲击，紧急情况下使用，
        /// 每个模式的停止是减速过程，冲击较小
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Halt(ushort AObj);

        /// <summary>
        /// 立即停止所有轴的运动，没有减速过程，对所有运动模式有效
        /// 紧急停止惯性较大的运动体时会对驱动器造成一定的冲击，紧急情况下使用，
        /// 每个模式的停止是减速过程，冲击较小
        /// </summary>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Halt_All();

        #endregion

        #region 位置模式的设置操作

        /// <summary>
        /// 设置指定的轴为开环位置模式
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Mode_Position_Open(ushort AObj);

        /// <summary>
        /// 设置位置模式下的最大速度
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">指定轴的位置模式下最大速度 Hz/S</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Position_V_Max(ushort AObj, int Value);

        /// <summary>
        /// 设置位置模式下的绝对目标位置, 开环模式下为目标开环脉冲数
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的位置模式下绝对目标位置 单位为(电机步数)可正可负</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Position_P_Target_Abs(ushort AObj, int Value);

        /// <summary>
        /// 停止指定轴的位置运动模式
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Position_Stop(ushort AObj);

        /// <summary>
        /// 设置指定轴的位置模式的加速度值，默认为500Hz/s²
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的加速度 Hz/S² 只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Position_Acc(ushort AObj, int Value);

        /// <summary>
        /// 设置指定轴的位置模式的减速度值，默认为500Hz/s²
        /// </summary>
        /// <param name="AObj">电机控制轴序号</param>
        /// <param name="Value">设置指定轴的减速度 Hz/S² 只能正</param>
        /// <returns>0代表函数执行成功; 否则执行失败</returns>
        [DllImport("MT_API.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MT_Set_Axis_Position_Dec(ushort AObj, int Value);

        #endregion
    }
}
