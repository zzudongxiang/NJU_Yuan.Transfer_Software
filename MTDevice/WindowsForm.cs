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

namespace MTDevice
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
        public WindowsForm(Core TestCore = null, Initializer INIFile = null, bool SubForm = false) 
        {
            InitializeComponent();

            // 如果是子窗口, 则无法使用操作
            btnLeft.Enabled = btnRight.Enabled = !SubForm;

            // 初始化对象
            if (INIFile is null) this.INIFile = new Initializer("Settings.ini");
            else this.INIFile = INIFile;
            if (TestCore is null) this.TestCore = new Core();
            else this.TestCore = TestCore;

            // 初始化界面显示
            cbxSelectAxis.Items.Clear();
            for (int i = 0; i < TestCore.AxisCount; i++)
            {
                string Section = "Axis-" + i.ToString();
                string Name = "[Axis-" + (i + 1).ToString() + "]";
                string Caption = INIFile.GetValue(Section, "Caption", "");
                if (!string.IsNullOrEmpty(Caption)) Name += " " + Caption;
                cbxSelectAxis.Items.Add(Name);
            }
            if (cbxSelectAxis.Items.Count > 0) cbxSelectAxis.SelectedIndex = 0;
        }

        /// <summary>
        /// 选择对应的轴数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelectAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取当前操作的轴对象
            int AxisIndex = cbxSelectAxis.SelectedIndex;
            if (AxisIndex < 0) return;
            if (AxisIndex > TestCore.Axises.Length) return;
            Axis CurrentAxis = TestCore.Axises[AxisIndex];

            // 更新设置中的标题内容
            tbxCaption.Text = CurrentAxis.Caption;

            // 更新轴的加速度与减速度值以及速度值
            nudAcc.Value = CurrentAxis.Acc;
            nudDecc.Value = CurrentAxis.Decc;
            nudMove.Value = CurrentAxis.Speed;

            // 更新轴的初始位与零位
            nudInit.Value = CurrentAxis.ZeroPosition;
            cbxPosZero.Checked = CurrentAxis.ZeroHome > 0;

            // 更新按钮的使能
            btnPre.Enabled = cbxSelectAxis.SelectedIndex != 0;
            btnNext.Enabled = cbxSelectAxis.SelectedIndex != cbxSelectAxis.Items.Count - 1;
        }

        /// <summary>
        /// 当控件失去焦点时自动保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Control_Leave(object sender, EventArgs e)
        {
            // 获取修改的部分内容
            string Key, Value = string.Empty;
            if (sender is Control Item)
                Key = Item.Tag.ToString();
            else return;

            // 读取相关的数据值
            if (sender is NumericUpDown nud)
                Value = nud.Value.ToString();
            else if (sender is TextBox tbx)
                Value = tbx.Text;

            // 将配置保存到配置文件中
            string Section = "Axis-" + cbxSelectAxis.SelectedIndex.ToString();
            INIFile.SetValue(Section, Key, Value);

            // 装载指定轴的参数
            TestCore.Load(cbxSelectAxis.SelectedIndex);

            // 如果当前发生更改的是名称, 则同步更新到选项框中
            if (sender is TextBox)
            {
                // 更新当前页面内容
                int Index = cbxSelectAxis.SelectedIndex;
                cbxSelectAxis.Items.RemoveAt(Index);
                cbxSelectAxis.Items.Insert(Index, "[Axis-" + (Index + 1).ToString() + "] " + tbxCaption.Text);
                cbxSelectAxis.SelectedIndex = Index;
            }
        }

        /// <summary>
        /// 当当前状态改变时, 自动保存配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPosZero_CheckedChanged(object sender, EventArgs e)
        {
            // 将配置保存到配置文件中
            string Section = "Axis-" + cbxSelectAxis.SelectedIndex.ToString();
            INIFile.SetValue(Section, "ZeroHome", cbxPosZero.Checked ? "1" : "-1");
            TestCore.Load(cbxSelectAxis.SelectedIndex);
        }

        /// <summary>
        /// 切换当前选择的轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AxisSelect_Click(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                int Index = cbxSelectAxis.SelectedIndex;
                if (btn.Tag.ToString() == "+")
                    Index++;
                else if (btn.Tag.ToString() == "-")
                    Index--;
                else return;
                if (Index >= 0 && Index < cbxSelectAxis.Items.Count)
                    cbxSelectAxis.SelectedIndex = Index;
            }
        }

        /// <summary>
        /// 对所有轴应用当前的配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxSaveAll_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("确定要修改所有轴的参数吗?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result != DialogResult.OK) return;
            for (int i = 0; i < TestCore.AxisCount; i++)
            {
                INIFile.SetValue("Axis-" + i.ToString(), "Acc", nudAcc.Value.ToString());
                INIFile.SetValue("Axis-" + i.ToString(), "Decc", nudDecc.Value.ToString());
                INIFile.SetValue("Axis-" + i.ToString(), "Speed", nudMove.Value.ToString());
                INIFile.SetValue("Axis-" + i.ToString(), "ZeroHome", cbxPosZero.Checked ? "1" : "0");
                TestCore.Load(i);
            }
            if (TestCore.AxisCount > 0)
                MessageBox.Show("已将该配置应用到全部轴", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("未能读到轴参数", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 使用当前的位置数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxInit_Click(object sender, EventArgs e)
        {
            nudInit.Value = TestCore.Axises[cbxSelectAxis.SelectedIndex].Position;
        }

        /// <summary>
        /// 停止当前轴的运动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHalt_Click(object sender, EventArgs e)
        {
            if (TestCore.Axises[cbxSelectAxis.SelectedIndex].Halt())
                MessageBox.Show("设备已停止", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("设备无法停止", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        /// <summary>
        /// 使用指定速度查找零位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!TestCore.Axises[cbxSelectAxis.SelectedIndex].Home())
                MessageBox.Show("当前轴正在运动", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 指定轴移动到指定位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInitVerifi_Click(object sender, EventArgs e)
        {
            TestCore.Axises[cbxSelectAxis.SelectedIndex].AutoHome();
        }

        /// <summary>
        /// 鼠标按下时开始运动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button btn)
            {
                int Speed = (int)nudMove.Value;
                if (btn.Tag.ToString() == "-")
                    Speed = -Speed;
                if (!TestCore.Axises[cbxSelectAxis.SelectedIndex].Start_Run(Speed))
                    MessageBox.Show("当前轴正在运动", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 鼠标松开时停止运动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Move_MouseUp(object sender, MouseEventArgs e)
        {
            if (!TestCore.Axises[cbxSelectAxis.SelectedIndex].Stop_Run())
                MessageBox.Show("当前轴正在运动", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 定时的刷新当前的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Data_Tick(object sender, EventArgs e)
        {
            if (TestCore.Axises is null || cbxSelectAxis.SelectedIndex < 0) return;

            // 显示轴的状态
            cbxRun.Checked = TestCore.Axises[cbxSelectAxis.SelectedIndex].isRun;
            cbxNeg.Checked = TestCore.Axises[cbxSelectAxis.SelectedIndex].isNeg;
            cbxPos.Checked = TestCore.Axises[cbxSelectAxis.SelectedIndex].isPos;
            cbxZero.Checked = TestCore.Axises[cbxSelectAxis.SelectedIndex].isZero;

            // 显示速度与位置信息
            lbV.Text = "当前速度: " + TestCore.Axises[cbxSelectAxis.SelectedIndex].Velocity;
            lbP.Text = "当前位置: " + TestCore.Axises[cbxSelectAxis.SelectedIndex].Position;
        }
    }
}
