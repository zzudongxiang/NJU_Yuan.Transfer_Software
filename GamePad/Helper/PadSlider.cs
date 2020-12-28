using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GamePad
{
    /// <summary>
    /// 摇杆的控制对象
    /// </summary>
    public class PadSlider
    {
        /// <summary>
        /// 输出当前摇杆的数值, 输出范围为-1 ~ 1 
        /// </summary>
        private double _Value = 0;

        /// <summary>
        /// 定义摇杆位于悬空时对应的数值
        /// </summary>
        private const int MidValue = ushort.MaxValue >> 1;
        
        /// <summary>
        /// 输出当前的数据
        /// </summary>
        public double Value
        {
            get { return _Value > 1 ? 1 : _Value < -1 ? -1 : _Value; }
            set
            {
                // 读取摇杆原始数据, 0 ~ 65535
                int OriValue = (int)value;

                // 定义允许变化的长度范围
                if (Math.Abs(OriValue - MidValue) > 5)
                    _Value = (double)(OriValue - MidValue) / MidValue;
                else _Value = 0;
            }
        }

        /// <summary>
        /// 当前摇杆的对象
        /// </summary>
        public PropertyInfo Slider { get; set; }

        /// <summary>
        /// 当前摇杆组的名字
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 初始化摇杆对象
        /// </summary>
        public PadSlider(string Name)
        {
            // 加载摇杆数据
            this.Name = Name;
            Load();
        }

        /// <summary>
        /// 从配置文件中读取摇杆的对象
        /// </summary>
        public void Load()
        {
            string Slider = Program.INIFile.GetValue("GamePad", Name, "X");
            foreach (PropertyInfo Item in typeof(API).GetProperties())
            {
                if (Item.Name.ToUpper().Equals(Slider.ToUpper()))
                {
                    this.Slider = Item;
                    return;
                }
            }
            this.Slider = typeof(API).GetProperties().First();
        }
    }
}
