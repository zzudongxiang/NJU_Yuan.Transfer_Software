using Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GamePad
{
    public partial class WindowsForm : Form
    {

        /// <summary>
        /// 进行电机测试的核心内容
        /// </summary>
        private Core TestCore { get; set; } = null;

        /// <summary>
        /// 配置文件对象
        /// </summary>
        private Initializer INIFile { get; set; } = null;

        /// <summary>
        /// 构造窗口
        /// </summary>
        public WindowsForm(Core TestCore = null, Initializer INIFile = null)
        {
            InitializeComponent();

            // 初始化对象
            if (INIFile is null) this.INIFile = new Initializer("Settings.ini");
            else this.INIFile = INIFile;
            if (TestCore is null) this.TestCore = new Core();
            else this.TestCore = TestCore;

            tabMain_SelectedIndexChanged(this, new EventArgs());

            // 初始化下拉选项单, 将待选择的按键列表填充到下拉选项单中
            string Format = "Button {0}";
            string[] ButtonItem = new string[50];
            for (int i = 0; i < ButtonItem.Length; i++) ButtonItem[i] = string.Format(Format, i);
            InitComboBox(pnlConfig, ButtonItem);
            SettingComboBox(pnlConfig, Format);

            // 将待选择的摇杆量填充到下拉选项单中
            List<string> ComboBoxList = new List<string> { };
            foreach (PropertyInfo Item in typeof(API).GetProperties())
            {
                string ItemType = Item.PropertyType.Name.ToString().ToUpper();
                if (ItemType.Equals("Int32".ToUpper()) || ItemType.Equals("Boolean".ToUpper()))
                    ComboBoxList.Add(Item.Name);
            }
            InitComboBox(pnlSlider, ComboBoxList.ToArray());
            SettingComboBox(pnlSlider, "{0}");

            // 方向键功能选择
            Format = "Point_Of_View {0}";
            string[] POVList = new string[4];
            for (int i = 0; i < POVList.Length; i++) POVList[i] = string.Format(Format, i);
            InitComboBox(pnlPOV, POVList);
            SettingComboBox(pnlPOV, Format);
        }


        /// <summary>
        /// 初始化可选择的按钮对象, 便利全部对象
        /// </summary>
        /// <param name="ParentControl">父控件对象</param>
        /// <param name="ButtonItem">要填充的列表数据</param>
        private void InitComboBox(Control ParentControl, string[] ItemList)
        {
            foreach (Control Item in ParentControl.Controls)
            {
                if (Item is Panel PNLItem) InitComboBox(PNLItem, ItemList);
                else if (Item is ComboBox CBXItem)
                {
                    CBXItem.Items.Clear();
                    CBXItem.Items.AddRange(ItemList);
                    CBXItem.SelectedIndex = 0;
                    CBXItem.SelectedIndexChanged += CBX_SelectedIndexChanged;
                }
            }
        }

        /// <summary>
        /// 根据配置文件对象更新选择框选择的数据
        /// </summary>
        /// <param name="ParentControl">父控件对象</param>
        /// <param name="Format">要选择的内容格式</param>
        private void SettingComboBox(Control ParentControl, string Format)
        {
            foreach (Control Item in ParentControl.Controls)
            {
                if (Item is Panel PNLItem) SettingComboBox(PNLItem, Format);
                else if (Item is ComboBox CBXItem)
                {
                    string Key = CBXItem.Name.Split('_').Last();
                    string Value = Program.INIFile.GetValue("GamePad", Key, "0");
                    CBXItem.SelectedItem = string.Format(Format, Value);
                }
            }
        }

        /// <summary>
        /// 当选择改变的时候自动修改配置文件中的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox Cbx = sender as ComboBox;
                string Key = Cbx.Name.Split('_').Last();
                string Value = Cbx.SelectedItem.ToString().Split(' ').Last();
                Program.INIFile.SetValue("GamePad", Key, Value);
                TestCore.Load();
            }
            catch (Exception Ex)
            {
                new Library.ExceptionBox().ShowException(Ex);
            }
        }

        /// <summary>
        /// 实时刷新手柄的操作数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Status_Tick(object sender, EventArgs e)
        {
            try
            {
                string ShowLine = string.Empty;
                Tmr_Status.Stop();

                // 更新预览界面中的摇杆信息
                lbLX.Text = string.Format("Left X ({0}) ->", TestCore.LX.ToString("0.000"));
                lbLY.Text = string.Format("Left Y ({0}) ->", TestCore.LY.ToString("0.000"));
                lbRX.Text = string.Format("Right X ({0}) ->", TestCore.RX.ToString("0.000"));
                lbRY.Text = string.Format("Right Y ({0}) ->", TestCore.RY.ToString("0.000"));
                
                // 更新预览信息中的ABXY组按钮信息
                lbA.Text = string.Format("A {0}->", TestCore.A ? "■" : "□");
                lbB.Text = string.Format("B {0}->", TestCore.B ? "■" : "□");
                lbX.Text = string.Format("X {0}->", TestCore.X ? "■" : "□");
                lbY.Text = string.Format("Y {0}->", TestCore.Y ? "■" : "□");
                
                // 更新预览界面中的LT, LB, RT, RB信息
                lbLT.Text = string.Format("LT {0}->", TestCore.LT ? "■" : "□");
                lbLB.Text = string.Format("LB {0}->", TestCore.LB ? "■" : "□");
                lbRT.Text = string.Format("RT {0}->", TestCore.RT ? "■" : "□");
                lbRB.Text = string.Format("RB {0}->", TestCore.RB ? "■" : "□");

                // 更新上下左右的信息
                ShowLine = string.Empty;
                ShowLine += "上" + (TestCore.Up ? "■" : "□") + " ";
                ShowLine += "下" + (TestCore.Down ? "■" : "□") + " ";
                ShowLine += "左" + (TestCore.Left ? "■" : "□") + " ";
                ShowLine += "右" + (TestCore.Right ? "■" : "□") + " ";
                lbPOV.Text = ShowLine + ">>";

                // 显示摇杆原始数据
                ShowLine = string.Empty;
                foreach (PropertyInfo Item in typeof(API).GetProperties())
                {
                    string ItemName = Item.Name;
                    string Value = Item.GetValue(TestCore.GamePadAPI, null).ToString();
                    if (new Regex(@"^\d+$").IsMatch(Value))
                        ShowLine += string.Format("{0}: {1}\r\n", ItemName, Value);
                }
                tbxOriSlider.Text = ShowLine;

                // 显示方向与滑杆数据
                ShowLine = string.Empty;
                for (int i = 0; i < TestCore.GamePadAPI.PointOfView.Length; i++)
                    ShowLine += string.Format("PointOfView_{0}: {1}\r\n", i, TestCore.GamePadAPI.PointOfView[i]);
                ShowLine += "\r\n";
                for (int i = 0; i < TestCore.GamePadAPI.Sliders.Length; i++)
                {
                    ShowLine += string.Format("AccSliders_{0}: {1}\r\n", i, TestCore.GamePadAPI.AccSliders[i]);
                    ShowLine += string.Format("ForSliders_{0}: {1}\r\n", i, TestCore.GamePadAPI.ForSliders[i]);
                    ShowLine += string.Format("VelSliders_{0}: {1}\r\n", i, TestCore.GamePadAPI.VelSliders[i]);
                    ShowLine += string.Format("   Sliders_{0}: {1}\r\n\r\n", i, TestCore.GamePadAPI.Sliders[i]);
                }
                tbxOriDir.Text = ShowLine;

                // 显示按键原始的数据
                ShowLine = string.Empty;
                for (int i = 0; i < 25; i++)
                    ShowLine += string.Format("Button_{0}: {1}\r\n", i, TestCore.GamePadAPI.Buttons[i]);
                tbxOriBtn_1.Text = ShowLine;
                ShowLine = string.Empty;
                for (int i = 25; i < 50; i++)
                    ShowLine += string.Format("Button_{0}: {1}\r\n", i, TestCore.GamePadAPI.Buttons[i]);
                tbxOriBtn_2.Text = ShowLine;

                Tmr_Status.Start();
            }
            catch (Exception Ex)
            {
                new Library.ExceptionBox().ShowException(Ex);
            }
        }

        /// <summary>
        /// 当切换菜单栏时自动修改长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Size NewSize = this.Size;
                if (tabMain.SelectedIndex == 0)
                    NewSize.Height = 400;
                else if (tabMain.SelectedIndex == 1)
                    NewSize.Height = 580;
                else if (tabMain.SelectedIndex == 2)
                    NewSize.Height = 390;
                else if (tabMain.SelectedIndex == 3)
                    NewSize.Height = 580;
                this.MaximumSize = NewSize;
                this.MinimumSize = NewSize;
                this.MaximumSize = NewSize;
                this.Size = NewSize;
            }
            catch (Exception Ex)
            {
                new Library.ExceptionBox().ShowException(Ex);
            }
        }
    }
}
