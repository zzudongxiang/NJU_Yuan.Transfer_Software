using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// 对字符串进行编码与解码的类
    /// </summary>
    public static class Coder
    {
        /// <summary>
        /// 对指定字符串进行base64编码
        /// </summary>
        /// <param name="Value">要编码的字符串对象</param>
        /// <returns>返回编码完成后的字符串对象</returns>
        public static string IniEncoder(string Value)
        {
            if (string.IsNullOrEmpty(Value)) return Value;
            try
            {
                byte[] CoderBytes = Encoding.UTF8.GetBytes(Value);
                return Convert.ToBase64String(CoderBytes).Replace("=", ".");
            }
            catch
            {
                return Value;
            }
        }

        /// <summary>
        /// 对指定的字符串进行base64解码
        /// </summary>
        /// <param name="Value">已经编码的字符串对象</param>
        /// <returns>返回编码后的字符串对象</returns>
        public static string IniDecoder(string Value)
        {
            if (string.IsNullOrEmpty(Value)) return Value;
            try
            {
                byte[] CoderBytes = Convert.FromBase64String(Value.Replace(".", "="));
                return Encoding.UTF8.GetString(CoderBytes);
            }
            catch
            {
                return Value;
            }
        }
    }
}
