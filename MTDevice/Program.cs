using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTDevice
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 检查相关的DLL文件是否存在
            string[] DllList = new string[] { "GamePad.exe", "Library.dll", "SharpDX.DirectInput.dll", "SharpDX.dll" };
            foreach (string Item in DllList)
            {
                if (!File.Exists(Item))
                {
                    string Message = "系统缺少 " + Item + " 文件, 软件无法正常启动!";
                    MessageBox.Show(Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 检查设备是否连接, 如果没有连接, 则退出运行
            if (!TestCore.Connect())
            {
                string Message = "===== 设备未连接 =====\r\n";
                Message += "无法连接设备, 请连接设备后重新尝试\r\n";
                MessageBox.Show(Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else Application.Run(new WindowsForm(TestCore, INIFile));
        }

        /// <summary>
        /// 储存读写配置文件的对象
        /// </summary>
        public static Library.Initializer INIFile { get; } = new Library.Initializer("Settings.ini");

        /// <summary>
        /// 进行电机测试的核心内容
        /// </summary>
        public static Core TestCore { get; set; } = new Core();

    }
}
