using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Library
{
    /// <summary>
    /// 读写配置文件的对象
    /// </summary>
    public class Initializer
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern uint GetPrivateProfileString(string section, string key, string defVal, byte[] lpReturnedString, uint nSize, string filePath);

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        /// <summary>
        /// 指示该Initializer对应的文件路径
        /// </summary>
        private string FilePath { get; }

        /// <summary>
        /// 读取缓冲区的大小设置
        /// </summary>
        private const int BuffSize = 65536;

        /// <summary>
        /// 构造Initializer对象, 传入*.ini的文件路径, 获取Initializer对象
        /// </summary>
        /// <param name="FilePath">*.ini的文件路径(可以是相对路径)</param>
        public Initializer(string FilePath)
        {
            FilePath += FilePath.Split('.').Last().ToLower().Equals("ini") ? string.Empty : ".ini";
            FileInfo SysFile = new FileInfo(FilePath);
            string DirPath = SysFile.Directory.FullName;
            if (!SysFile.Directory.Exists)
            {
                try
                {
                    if (File.Exists(DirPath)) File.Delete(DirPath);
                    Directory.CreateDirectory(SysFile.Directory.FullName);
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("无法在指定文件位置创建配置文件" + Ex.Message);
                }
            }
            this.FilePath = SysFile.FullName;
        }

        /// <summary>
        /// 设置一个ini属性值
        /// </summary>
        /// <param name="Section">章节名称</param>
        /// <param name="Key">键的名称</param>
        /// <param name="Value">键对应的值</param>
        public void SetValue(string Section, string Key, string Value)
        {
            // 对数据进行base64编码
            Section = Coder.IniEncoder(Section);
            Key = Coder.IniEncoder(Key);
            Value = Coder.IniEncoder(Value);

            // 写入到配置文件中
            WritePrivateProfileString(Section, Key, Value, FilePath);
        }

        /// <summary>
        /// 获取一个ini的属性值
        /// </summary>
        /// <param name="Section">章节名称</param>
        /// <param name="Key">键的名称</param>
        /// <param name="DefaultValue">若该值不存在, 则返回的默认值</param>
        /// <returns>返回获取到的结果或默认值</returns>
        public string GetValue(string Section, string Key, string DefaultValue)
        {
            // 对数据进行base64编码
            Section = Coder.IniEncoder(Section);
            Key = Coder.IniEncoder(Key);
            DefaultValue = Coder.IniEncoder(DefaultValue);

            // 从配置文件中读取数据
            StringBuilder ReadBuffer = new StringBuilder(BuffSize);
            GetPrivateProfileString(Section, Key, DefaultValue, ReadBuffer, ReadBuffer.Capacity, FilePath);
            return Coder.IniDecoder(ReadBuffer.ToString());
        }

        /// <summary>
        /// 删除一个ini的属性值
        /// </summary>
        /// <param name="Section">章节名称</param>
        /// <param name="Key">键的名称</param>
        public void DeleteValue(string Section, string Key)
        {
            // 对数据进行base64编码
            Section = Coder.IniEncoder(Section);
            Key = Coder.IniEncoder(Key);

            // 删除指定的Key
            SetValue(Section, Key, null);
        }

        /// <summary>
        /// 删除一个Section下所有内容
        /// </summary>
        /// <param name="Section">Section名称</param>
        public void DeleteSection(string Section)
        {
            // 对数据进行base64编码
            Section = Coder.IniEncoder(Section);

            // 删除指定的Section
            SetValue(Section, null, null);
        }

        /// <summary>
        /// 获取一个Section下所有Key的列表
        /// </summary>
        /// <param name="Section">节点的名称</param>
        /// <returns>返回Section列表</returns>
        public List<string> GetKeys(string Section)
        {
            // 对数据进行base64编码
            Section = Coder.IniEncoder(Section);

            // 读取配置文件中的数据长度
            List<string> Keys = new List<string>();
            byte[] Buffer = new byte[BuffSize];
            uint Length = GetPrivateProfileString(Section, null, null, Buffer, (uint)Buffer.Length, FilePath);
            int Index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (Buffer[i] == 0)
                {
                    string Key = Encoding.Default.GetString(Buffer, Index, i - Index);
                    Keys.Add(Coder.IniDecoder(Key));
                    Index = i + 1;
                }
            }
            return Keys;
        }
    }
}
