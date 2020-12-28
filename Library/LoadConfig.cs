using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// 从配置文件中加载数据
    /// </summary>
    public static class LoadConfig
    {
        /// <summary>
        /// 从配置文件中读取数值
        /// </summary>
        /// <param name="INIFile">对应的配置文件读写对象</param>
        /// <param name="Section">读写的章节</param>
        /// <param name="Key">读写的键值</param>
        /// <param name="Default">找不到结果返回的默认值</param>
        /// <returns>返回读取结果</returns>
        public static int LoadValue(Initializer INIFile, string Section, string Key, int Default)
        {
            string Value = INIFile.GetValue(Section, Key, Default.ToString());
            if (!new Regex(@"^(\+|\-)?\d+$").IsMatch(Value))
            {
                INIFile.SetValue(Section, Key, Default.ToString());
                return Default;
            }
            else return Convert.ToInt32(Value);
        }
    }
}
