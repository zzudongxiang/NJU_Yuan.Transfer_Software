using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GamePad
{
    /// <summary>
    /// 上下左右的方向键
    /// </summary>
    public class PadPOV
    {
        /// <summary>
        /// 当前对应的POV索引
        /// </summary>
        public int Index { get; private set; } = 0;

        /// <summary>
        /// 当前POV的名字, 用于记录到配置文件中
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <param name="Name"></param>
        public PadPOV(string Name)
        {
            this.Name = Name;
        }

        /// <summary>
        /// 从配置文件中读取数据
        /// </summary>
        public void Load()
        {
            string Value = Program.INIFile.GetValue("GamePad", Name, Index.ToString());
            if (new Regex(@"^\d+$").IsMatch(Value)) Index = Convert.ToInt32(Value);
            else Program.INIFile.SetValue("GamePad", Name, Index.ToString());
        }
    }
}
