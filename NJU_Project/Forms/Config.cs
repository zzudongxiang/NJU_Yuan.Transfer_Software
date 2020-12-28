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
    public partial class Config : Form
    {
        public Config(Core TestCore = null, Initializer INIFile = null)
        {
            InitializeComponent();

            // 初始化对象
            if (INIFile is null) this.INIFile = new Initializer("Settings.ini");
            else this.INIFile = INIFile;
            if (TestCore is null) this.TestCore = new Core();
            else this.TestCore = TestCore;

            // 初始化下拉选项框
            cbxSelectAxis.Items.Clear();
            for (int i = 0; i < TestCore.MTDevice.Axises.Length; i++)
            {
                string Section = "Axis-" + i.ToString();
                string Name = "[Axis-" + (i + 1).ToString() + "]";
                string Caption = INIFile.GetValue(Section, "Caption", "");
                if (!string.IsNullOrEmpty(Caption)) Name += " " + Caption;
                cbxSelectAxis.Items.Add(Name);
            }
            if (cbxSelectAxis.Items.Count > 0) cbxSelectAxis.SelectedIndex = 0;

            // 更改对应文件的工作模式
            TestCore.WorkMode = Core.Mode.AxisMove;

        }

        /// <summary>
        /// 显示手柄设置的窗口
        /// </summary>
        private GamePad.WindowsForm PadForm { get; set; }

        /// <summary>
        /// 显示设备属性的窗口
        /// </summary>
        private MTDevice.WindowsForm MTForm { get; set; }

        /// <summary>
        /// 设置当前属性的对象
        /// </summary>
        private Core TestCore { get; set; }

        /// <summary>
        /// 读写配置文件所在的位置
        /// </summary>
        private Initializer INIFile { get; set; }

        /// <summary>
        /// 打开手柄设置的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxGamepad_Click(object sender, EventArgs e)
        {
            lbGamePad.Enabled = pbxGamepad.Enabled = false;
            if (!(PadForm is null)) PadForm.Dispose();
            PadForm = new GamePad.WindowsForm(TestCore.PadDevice, INIFile);
            PadForm.Show();
        }

        /// <summary>
        /// 打开设备设置的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxMT_Click(object sender, EventArgs e)
        {
            lbMT.Enabled = pbxMT.Enabled = false;
            if (!(MTForm is null)) MTForm.Dispose();
            MTForm = new MTDevice.WindowsForm(TestCore.MTDevice, INIFile, true);
            MTForm.Show();
        }

        /// <summary>
        /// 切换选择的轴时自动切换对象
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxSelectAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取当前操作的轴对象
            int AxisIndex = cbxSelectAxis.SelectedIndex;
            if (AxisIndex < 0) return;
            if (AxisIndex > TestCore.MTDevice.Axises.Length) return;
            TestCore.CurrentAxis = AxisIndex;

            // 更新轴的档位速度
            nudLevel0.Value = TestCore._CurrentAxis.SpeedArray[0];
            nudLevel1.Value = TestCore._CurrentAxis.SpeedArray[1];
            nudLevel2.Value = TestCore._CurrentAxis.SpeedArray[2];
            nudLevel3.Value = TestCore._CurrentAxis.SpeedArray[3];

            // 更新轴的反转状态
            cbxRev.Checked = TestCore._CurrentAxis.Axis_Rev;

            // 更新按钮的使能
            btnPre.Enabled = cbxSelectAxis.SelectedIndex != 0;
            btnNext.Enabled = cbxSelectAxis.SelectedIndex != cbxSelectAxis.Items.Count - 1;
        }

        /// <summary>
        /// 切换到上一轴或下一轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
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
        /// 停止当前轴的运动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxHalt_Click(object sender, EventArgs e)
        {
            TestCore.MTDevice.HaltAll();
            MessageBox.Show("已停止所有轴的运动", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 当数值发生改变时, 自动更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudLevel0_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown nud)
            {
                // 操作对象越界检查
                if (cbxSelectAxis.SelectedIndex < 0 || cbxSelectAxis.SelectedIndex >= TestCore.MTDevice.AxisCount) return;
                if (TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex] is null) return;

                // 储存数据结果
                string Key = "Axis-" + cbxSelectAxis.SelectedIndex.ToString();
                INIFile.SetValue(Key, nud.Tag.ToString(), nud.Value.ToString());
                TestCore.Load();
            }
        }

        /// <summary>
        /// 保存全部的结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxSaveAll_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("确定要修改所有轴的参数吗?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result != DialogResult.OK) return;

            for (int i = 0; i < TestCore.MTDevice.AxisCount; i++)
            {
                // 储存数据结果
                string Key = "Axis-" + i.ToString();
                INIFile.SetValue(Key, "Speed_0", nudLevel0.Value.ToString());
                INIFile.SetValue(Key, "Speed_1", nudLevel1.Value.ToString());
                INIFile.SetValue(Key, "Speed_2", nudLevel2.Value.ToString());
                INIFile.SetValue(Key, "Speed_3", nudLevel3.Value.ToString());
                //INIFile.SetValue(Key, "Rev", cbxRev.Checked ? "1" : "-1");

                // 操作对象越界检查, 更重新装载文件
                if (TestCore.MTDevice.Axises[i] is null) continue;
            }
            TestCore.Load();

            // 反馈更新结果
            if (TestCore.MTDevice.AxisCount > 0)
                MessageBox.Show("已将该配置应用到全部轴", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("未能读到轴参数", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 实时刷新当前的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Data_Tick(object sender, EventArgs e)
        {
            // 属性界面状态检查
            lbGamePad.Enabled = pbxGamepad.Enabled = PadForm is null || !PadForm.Visible;
            lbMT.Enabled = pbxMT.Enabled = MTForm is null || !MTForm.Visible;

            // 检查选择越界
            if (cbxSelectAxis.SelectedIndex < 0) return;

            // 显示轴的状态
            cbxRun.Checked = TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex].isRun;
            cbxNeg.Checked = TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex].isNeg;
            cbxPos.Checked = TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex].isPos;
            cbxZero.Checked = TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex].isZero;

            // 显示速度与位置信息
            lbV.Text = "当前速度: " + TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex].Velocity;
            lbP.Text = "当前位置: " + TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex].Position;
        }

        /// <summary>
        /// 轴控制方向反转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRev_CheckedChanged(object sender, EventArgs e)
        {
            // 操作对象越界检查
            if (cbxSelectAxis.SelectedIndex < 0 || cbxSelectAxis.SelectedIndex >= TestCore.MTDevice.AxisCount) return;
            if (TestCore.MTDevice.Axises[cbxSelectAxis.SelectedIndex] is null) return;

            // 储存数据结果
            string Key = "Axis-" + cbxSelectAxis.SelectedIndex.ToString();
            INIFile.SetValue(Key, "Rev", cbxRev.Checked ? "1" : "-1");
            TestCore.Load();
        }
    }
}
