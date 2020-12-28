using System.ComponentModel;
using System.Threading;

namespace MTDevice
{
    /// <summary>
    /// 当前设备的核心内容部分
    /// </summary>
    public class Core
    {
        /// <summary>
        /// 设备关联的轴对象集合
        /// </summary>
        public Axis[] Axises { get; private set; } = new Axis[] { };

        /// <summary>
        /// 该设备连接的轴体的个数
        /// </summary>
        public int AxisCount
        {
            get
            {
                return Axises.Length;
            }
            private set
            {
                if (value > 0)
                {
                    Axises = new Axis[value];
                    for (int i = 0; i < AxisCount; i++)
                        Axises[i] = new Axis((ushort)i);
                }
                else
                {
                    Axises = new Axis[] { };
                }
            }
        }

        /// <summary>
        /// 当前设备连接的情况
        /// </summary>
        public bool Status { get; private set; }

        /// <summary>
        /// 设备的版本号
        /// </summary>
        public string Version { get; private set; } = "0";

        /// <summary>
        /// 设备的ID
        /// </summary>
        public string ID { get; private set; } = "0.0.0.0";

        /// <summary>
        /// 连接设备
        /// </summary>
        /// <returns>是否成功连接设备</returns>
        public bool Connect()
        {
            if (!Status)
            {
                // 加载API的资源
                try { API.MT_Init(); }
                catch { } 
                
                // 尝试连接设备, 并进行握手检查
                if (API.MT_Close_USB() == 0 && API.MT_Open_USB() == 0 && API.MT_Check() == 0)
                {
                    // 读取当前设备连接的轴个数
                    int AxisCount = -1;
                    if (API.MT_Get_Axis_Num(ref AxisCount) == 0)
                    {
                        this.AxisCount = AxisCount;

                        // 读取设备的版本与序列号信息
                        int ID = 0;
                        if (API.MT_Get_Product_ID(ref ID) == 0)
                            this.ID = ID.ToString();
                        int Major = 0;
                        int Minor = 0;
                        int Release = 0;
                        int Build = 0;
                        if (API.MT_Get_Product_Version2(ref Major, ref Minor, ref Release, ref Build) == 0)
                            Version = string.Format("{0}.{1}.{2}.{3}", Major, Minor, Release, Build);

                        // 返回连接成功的信息
                        Status = true;
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// 断开设备的连接
        /// </summary>
        public void DisConnect()
        {
            // 清空相关的变量
            AxisCount = 0;
            ID = "0";
            Version = "0.0.0.0";
            Status = false;

            // 停止设备的运转
            HaltAll();

            // 关闭连接断口, 并释放资源
            API.MT_Close_USB();
            try { API.MT_DeInit(); }
            catch { }
        }

        /// <summary>
        /// 紧急停止全部轴的运动
        /// </summary>
        public void HaltAll()
        {
            // 紧急停止全部电机
            API.MT_Set_Axis_Halt_All();

            // 依次紧急停止全部电机
            if (Axises.Length <= 0) return;
            for (int i = 0; i < AxisCount; i++)
                Axises[i].Halt();
        }

        /// <summary>
        /// 所有轴自动恢复到初始位置
        /// </summary>
        public void AutoHome()
        {
            if (Axises.Length <= 0) return;
            for (int i = 0; i < AxisCount; i++)
                Axises[i].AutoHome();
        }

        /// <summary>
        /// 从配置文件中装载指定数据
        /// </summary>
        /// <param name="Index">要装载的轴索引, 如果是负数, 则全部装载</param>
        public void Load(int Index = -1)
        {
            if (Axises.Length <= 0) return;
            if (Index < 0)
            {
                for (int i = 0; i < AxisCount; i++)
                    Axises[i].Load();
            }
            else if (Index < Axises.Length)
                Axises[Index].Load();
        }

    }
}
