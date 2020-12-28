using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GamePad
{
    /// <summary>
    /// 游戏手柄的对象
    /// </summary>
    public class PadButton
    {
        /// <summary>
        /// 当前按钮的名字
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 初始化按钮按键的对象
        /// </summary>
        /// <param name="Name">按钮的名称</param>
        public PadButton(string Name) 
        { 
            this.Name = Name;
            Load();
        }

        /// <summary>
        /// 当前按键绑定的索引对象
        /// </summary>
        public int Index { get; private set; } = 0;

        /// <summary>
        /// 从配置文件中读取相关的属性
        /// </summary>
        public void Load()
        {
            string Value = Program.INIFile.GetValue("GamePad", Name, Index.ToString());
            if (new Regex(@"^\d+$").IsMatch(Value)) Index = Convert.ToInt32(Value);
            else Program.INIFile.SetValue("GamePad", Name, Index.ToString());
        }
    }
}
