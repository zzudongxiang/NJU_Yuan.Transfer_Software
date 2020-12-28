using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NJU_Project
{
    public partial class WindowsForm : Form
    {

        /// <summary>
        /// 设置当前属性的对象
        /// </summary>
        private Core TestCore { get; set; }

        /// <summary>
        /// 读写配置文件所在的位置
        /// </summary>
        private Initializer INIFile { get; set; }

        /// <summary>
        /// 当前工作模式与显示名称的对应关系
        /// </summary>
        private Dictionary<string, string> ListItem { get; } = new Dictionary<string, string>
        {
            { "Rotation", "旋转倾斜" },
            { "GroupA_XY", "A组 XY轴" },
            { "GroupB_XY", "B组 XY轴" },
            { "GroupA_Z", "A组 Z轴" },
            { "GroupB_Z", "B组 Z轴" },
            { "MoveXY_Sync", "XY同步" },
            { "MoveZ_Sync", "Z轴同步" },
        };

        /// <summary>
        /// 指示当前是否是二级菜单
        /// </summary>
        private bool IsMenu { get; }

        /// <summary>
        /// 当前可选择的Label对象列表
        /// </summary>
        private List<Label> LabelList { get; } = new List<Label> { };

        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <param name="TestCore"></param>
        /// <param name="INIFile"></param>
        public WindowsForm(Core TestCore = null, Initializer INIFile = null, bool Menu = false)
        {
            InitializeComponent();
            PressTime = DateTime.Now.AddDays(-1);

            // 初始化对象
            if (INIFile is null) INIFile = new Initializer("Settings.ini");
            this.INIFile = INIFile;
            if (TestCore is null) TestCore = new Core();
            this.TestCore = TestCore;
            this.IsMenu = Menu;

            if (!Menu)
            {
                // 构造显示的各个对象集合
                Axis[] Axises = new Axis[]
                {
                    TestCore._GroupA_X,
                    TestCore._GroupA_Y,
                    TestCore._GroupA_Z,

                    TestCore._GroupB_X,
                    TestCore._GroupB_Y,
                    TestCore._GroupB_Z,

                    TestCore._Rotation_X,
                    TestCore._Rotation_Y,
                    TestCore._Rotation_Z,

                };

                // 状态显示页面
                foreach (Axis Item in Axises)
                {
                    string ItemName = TestCore.MTDevice.Axises[Item.Index].Caption;
                    if (!string.IsNullOrEmpty(ItemName)) ItemName += " ";
                    ItemName += "[Axis-" + (Item.Index + 1) + "]";
                    AxisStatusForm FormControl = new AxisStatusForm(TestCore, Item, INIFile);
                    ToolStripItem tsi = 轴状态显示AToolStripMenuItem.DropDownItems.Add(ItemName);
                    tsi.Tag = FormControl;
                    tsi.Click += Tsi_Click;
                }

                // 综合状态显示
                综合状态显示MToolStripMenuItem.Tag = new ModeStatus(TestCore, INIFile);
            }
            // 刷新当前选择的菜单对象
            this.Height = this.Padding.Top + this.Padding.Bottom;
            pnlMain.Controls.Clear();
            List<KeyValuePair<string, int>> Items = new List<KeyValuePair<string, int>> { };
            // 如果是主窗口, 则使用初始位置
            if (!Menu)
            {
                // 记录初始位数据
                Program.Record = new int[TestCore.MTDevice.Axises.Length];
                for (int i = 0; i < TestCore.MTDevice.Axises.Length; i++)
                    Program.Record[i] = TestCore.MTDevice.Axises[i].ZeroPosition;

                // 添加一级菜单
                Items.Add(new KeyValuePair<string, int>("---", -1));
                Items.Add(new KeyValuePair<string, int>(">>高级<<", -1));
                Items.Add(new KeyValuePair<string, int>("---", -1));
                foreach (object Item in Enum.GetValues(typeof(Core.Mode)))
                {
                    string ItemName = Enum.GetName(typeof(Core.Mode), Item);
                    if (ListItem.ContainsKey(ItemName))
                        Items.Add(new KeyValuePair<string, int>(ListItem[ItemName], (int)Item));
                }

                // 初始化子菜单
                SubMenu = new WindowsForm(TestCore, INIFile, true);
            }
            else
            {
                // 添加二级菜单
                Items.Add(new KeyValuePair<string, int>("---", -1));
                Items.Add(new KeyValuePair<string, int>("全部复位", -1));
                Items.Add(new KeyValuePair<string, int>("---", -1));
                Items.Add(new KeyValuePair<string, int>("记录位置", -2));
                Items.Add(new KeyValuePair<string, int>("恢复位置", -3));
                Items.Add(new KeyValuePair<string, int>("---", -1));
                Items.Add(new KeyValuePair<string, int>("设备校准", -4));
                ntfSys.Visible = false;
            }
            
            // 初始化对象
            for (int i = Items.Count - 1; i >= 0; i--)
            {
                Label tmpLabel = new Label()
                {
                    Dock = DockStyle.Top,
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Gainsboro,
                    Font = new Font("微软雅黑", 36, FontStyle.Bold),
                };
                if (Items[i].Key != "---")
                {
                    tmpLabel.Height = 80;
                    tmpLabel.BackColor = Color.Transparent;
                    tmpLabel.Text = Items[i].Key;
                    tmpLabel.Tag = Items[i].Value;
                    LabelList.Add(tmpLabel);
                }
                else
                {
                    tmpLabel.Height = 5;
                    tmpLabel.BackColor = Color.FromArgb(97, 27, 123);
                }
                pnlMain.Controls.Add(tmpLabel);
                this.Height += tmpLabel.Height;
            }
            this.Height += pnlTitle.Height;

            // 选择默认选项
            SelectingIndex = LabelList.Count - 1;
        }

        /// <summary>
        /// 显示轴状态窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsi_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripItem tsi && tsi.Tag is Form asf)
                asf.Visible = !asf.Visible;
        }

        /// <summary>
        /// 指示是否松开按键
        /// </summary>
        public bool ButtonUp { get; set; } = true;

        /// <summary>
        /// 二级菜单对象
        /// </summary>
        private WindowsForm SubMenu { get; }

        /// <summary>
        /// 当前正在选择的项目序号
        /// </summary>
        private int _SelectingIndex = 0;

        /// <summary>
        /// 当前正在选择的索引序号
        /// </summary>
        private int SelectingIndex
        {
            get { return _SelectingIndex; }
            set
            {
                if (SelectingIndex != value)
                {
                    if (value < 0) value = LabelList.Count - 1;
                    _SelectingIndex = value % LabelList.Count;
                    foreach (Label Item in LabelList)
                        Item.BackColor = pnlMain.BackColor;
                    LabelList[SelectingIndex].BackColor = Color.FromArgb(122, 37, 154);
                }
            }
        }

        /// <summary>
        /// 记录按下按键时的时间
        /// </summary>
        public DateTime PressTime { get; set; }

        /// <summary>
        /// 后台运行的按键扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Button_Tick(object sender, EventArgs e)
        {
            Tmr_Button.Stop();

            // 处理上下按键
            if (this.Visible || !IsMenu)
            {
                // 切换当前选择的项目
                if (TestCore.PadDevice.Up && ButtonUp)
                {
                    this.Show();
                    PressTime = DateTime.Now;
                    ButtonUp = false;
                    SelectingIndex++;
                }
                else if (TestCore.PadDevice.Down && ButtonUp)
                {
                    this.Show();
                    PressTime = DateTime.Now;
                    ButtonUp = false;
                    SelectingIndex--;
                }
                else
                {
                    if (!TestCore.PadDevice.Up && !TestCore.PadDevice.Down &&
                        !TestCore.PadDevice.Left && !TestCore.PadDevice.Right &&
                        !TestCore.PadDevice.A && !TestCore.PadDevice.B && 
                        !TestCore.PadDevice.X && !TestCore.PadDevice.Y)
                        ButtonUp = true;
                }
            }

            // 处理左右按键
            if (this.Visible)
            {
                // 如果按下右方向键, 认为选中该选项
                if ((TestCore.PadDevice.Right || TestCore.PadDevice.X || TestCore.PadDevice.A) && ButtonUp)
                {
                    int Mode = (int)LabelList[SelectingIndex].Tag;
                    if (Mode < 0)
                    {
                        if (!IsMenu)
                        {
                            // 打开二级选择菜单
                            this.Hide();
                            SubMenu.PressTime = DateTime.Now;
                            SubMenu.ButtonUp = false;
                            DialogResult Result = SubMenu.ShowDialog();
                            if (Result != DialogResult.OK)
                            {
                                this.Show();
                                ButtonUp = false;
                                PressTime = DateTime.Now;
                            }
                        }
                        else if (IsMenu)
                        {
                            if (Mode == -1)
                            {
                                // 二级菜单的全部复位功能
                                foreach (MTDevice.Axis Item in TestCore.MTDevice.Axises)
                                    Item.AutoHome();
                                ntfSys.ShowBalloonTip(3000, "消息", "正在进行复位", ToolTipIcon.Info);
                                this.DialogResult = DialogResult.OK;
                            }
                            else if (Mode == -2)
                            {
                                // 二级菜单的记录当前位置功能
                                for (int i = 0; i < TestCore.MTDevice.Axises.Length; i++)
                                    Program.Record[i] = TestCore.MTDevice.Axises[i].Position;
                                ntfSys.ShowBalloonTip(3000, "消息", "当前位置已记录", ToolTipIcon.Info);
                                this.DialogResult = DialogResult.OK;
                            }
                            else if (Mode == -3)
                            {
                                // 二级菜单的恢复当前位置功能
                                for (int i = 0; i < TestCore.MTDevice.Axises.Length; i++)
                                    TestCore.MTDevice.Axises[i].Run(Program.Record[i]);
                                ntfSys.ShowBalloonTip(3000, "消息", "正在恢复到指定位置", ToolTipIcon.Info);
                                this.DialogResult = DialogResult.OK;
                            }
                            else if (Mode == -4)
                            {
                                // 设备校准
                                foreach (MTDevice.Axis Item in TestCore.MTDevice.Axises)
                                    Item.Home();
                                ntfSys.ShowBalloonTip(3000, "消息", "设备正在校准中", ToolTipIcon.Info);
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else
                    {
                        TestCore.WorkMode = (Core.Mode)Mode;
                        this.Hide();
                    }
                }
                else if ((TestCore.PadDevice.Left || TestCore.PadDevice.Y || TestCore.PadDevice.B) && ButtonUp) 
                {
                    this.Hide();
                    DialogResult = DialogResult.Cancel; 
                }

                // 计算是否自动关闭窗口
                if ((DateTime.Now - PressTime).TotalSeconds > 5) this.Hide();
            }

            // 重新开启定时器
            Tmr_Button.Start();
        }

        /// <summary>
        /// 编辑电机与设备属性的编辑框
        /// </summary>
        private Config ConfigForm { get; set; }

        /// <summary>
        /// 编辑属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 编辑相关属性SToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!(ConfigForm is null)) ConfigForm.Dispose();
            ConfigForm = new Config(TestCore, INIFile);
            ConfigForm.Show();
        }

        /// <summary>
        /// 打开窗口时更改属性界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsSys_Opening(object sender, CancelEventArgs e)
        {
            // 各个轴的状况
            foreach (ToolStripItem Item in 轴状态显示AToolStripMenuItem.DropDownItems)
            {
                if(Item.Tag is AxisStatusForm asf)
                {
                    Item.Image = asf.Visible ? Properties.Resources.Hide_Black : Properties.Resources.Show;
                }
            }

            // 综合状态的情况
            if (综合状态显示MToolStripMenuItem.Tag is ModeStatus ms)
            {
                综合状态显示MToolStripMenuItem.Image = ms.Visible ? Properties.Resources.Hide_Black : Properties.Resources.Show;
            }
        }

        /// <summary>
        /// 退出程序的运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("是否退出程序?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes) Application.Exit();
        }
    }
}
