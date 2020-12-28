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
    public partial class AxisStatusForm : Form
    {
        /// <summary>
        /// 当前对应的轴
        /// </summary>
        private Axis CurrAxis { get; }

        /// <summary>
        /// 当前对应的对象
        /// </summary>
        private Core CurrCore { get; }

        /// <summary>
        /// 读写配置文件对应的位置
        /// </summary>
        private Initializer INIFile { get; }

        /// <summary>
        /// 当前对应的配置文件索引名称
        /// </summary>
        private string Key { get; }

        /// <summary>
        /// 初始化窗口
        /// </summary>
        public AxisStatusForm(Core CurrCore, Axis CurrAxis, Initializer INIFile, bool SubForm = false) 
        {
            InitializeComponent();
            lbTitle_Resize(this, new EventArgs());

            // 初始化对象
            this.CurrCore = CurrCore;
            this.CurrAxis = CurrAxis;
            this.INIFile = INIFile;
            Key = "Axis-" + CurrAxis.Index.ToString();

            // 刷新数据
            Tmr_Sys_Tick(this, new EventArgs());

            // 给窗口添加移动事件
            if (!SubForm)
            {
                new FormMove(this);
                new FormSave(this, INIFile, Key);
            }
        }

        /// <summary>
        /// 当标题的长度修改时, 自动修改窗口的长度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTitle_Resize(object sender, EventArgs e)
        {
            pgbStatus.Height = lbP.Height;
            this.Height = this.Padding.Top + this.Padding.Bottom;
            this.Height += pnlMain.Padding.Top+ pnlMain.Padding.Bottom;
            this.Height += lbTitle.Height + lbP.Height;

            this.Width = this.Padding.Left + this.Padding.Right;
            this.Width += pnlMain.Padding.Left + pnlMain.Padding.Right;
            this.Width += Math.Max(lbTitle.Width, lbP.Width + 100);
        }

        /// <summary>
        /// 记录上一次的移动位置
        /// </summary>
        private int LastPosition { get; set; } = 0;

        /// <summary>
        /// 当前是否高亮
        /// </summary>
        private bool High { get; set; } = false;

        /// <summary>
        /// 减慢闪烁速度
        /// </summary>
        private int HighCount { get; set; } = 0;

        /// <summary>
        /// 闪烁频率
        /// </summary>
        private int FlashCount { get; set; } = 2;

        /// <summary>
        /// 定时刷新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Sys_Tick(object sender, EventArgs e)
        {
            // 如果当前不显示, 则自动不更新内容
            Tmr_Sys.Stop();

            // 显示当前的档位
            bool ShowLevel = CurrCore.WorkMode != Core.Mode.MoveXY_Sync && CurrCore.WorkMode != Core.Mode.MoveZ_Sync;
            if (CurrAxis.Selected)
            {
                bool T_Button = CurrAxis.T_Button;
                bool B_Button = CurrAxis.B_Button;
                if (ShowLevel && T_Button && B_Button)
                {
                    FlashCount = 2;
                    pgbStatus.Value = 100;
                }
                else if (ShowLevel && T_Button && !B_Button)
                {
                    FlashCount = 4;
                    pgbStatus.Value = 70;
                }
                else if (ShowLevel && !T_Button && B_Button)
                {
                    FlashCount = 6;
                    pgbStatus.Value = 50;
                }
                else 
                {
                    FlashCount = 8;
                    pgbStatus.Value = 40;
                }
            }
            else
            {
                FlashCount = 10;
                pgbStatus.Value = 0;
            }

            // 显示当前的运动状态
            int Position = CurrCore.MTDevice.Axises[CurrAxis.Index].Position;
            if (Position != LastPosition)
            {
                if ((++HighCount) % FlashCount == 0) High = !High;
                LastPosition = Position;
                if (High) pnlMain.BackColor = Color.FromArgb(0, 255, 0);
                else pnlMain.BackColor = Color.FromArgb(6, 176, 37);
                lbP.Text = "位置: " + (LastPosition >= 0 ? "+" : "") + LastPosition.ToString("000000");
            }
            else
            {
                HighCount = 0;
                High = true;
                pnlMain.BackColor = Color.Transparent;
            }

            // 显示标题
            string Caption = CurrCore.MTDevice.Axises[CurrAxis.Index].Caption;
            Caption+= " [Axis-" + (CurrAxis.Index + 1).ToString() + "]";
            if (lbTitle.Text != Caption)
            {
                this.Text = "NJU - " + Caption;
                lbTitle.Text = Caption;
            }

            Tmr_Sys.Start();
        }

        /// <summary>
        /// 修改窗口的可见性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
