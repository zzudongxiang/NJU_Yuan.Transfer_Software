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
    public partial class ModeStatus : Form
    {
        /// <summary>
        /// 调用的核心对象
        /// </summary>
        private Core TestCore { get; }

        /// <summary>
        /// 调用的配置文件
        /// </summary>
        private Initializer INIFile { get; }

        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="TestCore"></param>
        /// <param name="INIFile"></param>
        public ModeStatus(Core TestCore = null, Initializer INIFile = null)
        {
            InitializeComponent();

            // 初始化对象
            if (INIFile is null) this.INIFile = new Initializer("Settings.ini");
            else this.INIFile = INIFile;
            if (TestCore is null) this.TestCore = new Core();
            else this.TestCore = TestCore;

            // 修改B的颜色及图案
            Bitmap bmp = new Bitmap(pbxGroupB.Width, pbxGroupB.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillEllipse(new SolidBrush(pbxGroupB.BackColor), 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            pbxGroupB.BackColor = Color.Transparent;
            pbxGroupB.Image = bmp;

            // 给窗口添加移动事件
            new FormMove(this);
            new FormSave(this, INIFile, "Status");

            // 偏移量获取
            nudX.Value = LoadConfig.LoadValue(INIFile, "NJU_Project", "OffsetX", 0);
            nudY.Value = LoadConfig.LoadValue(INIFile, "NJU_Project", "OffsetY", 0);
            nudZ.Value = LoadConfig.LoadValue(INIFile, "NJU_Project", "OffsetZ", 0);
            nudX.ValueChanged += nud_ValueChanged;
            nudY.ValueChanged += nud_ValueChanged;
            nudZ.ValueChanged += nud_ValueChanged;

            // 获取可移动的最小长度
            MinLength = Math.Min(pnlMain.Width, pnlMain.Height);

            // 刷新对象
            Tmr_Sys_Tick(this, new EventArgs());
        }

        /// <summary>
        /// 隐藏综合显示窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 隐藏HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        /// <summary>
        /// X方向偏移量
        /// </summary>
        private int OffsetX 
        { 
            get { return (int)nudX.Value; }
            set { INIFile.SetValue("NJU_Project", "OffsetX", value.ToString()); }
        }

        /// <summary>
        /// Y方向偏移量
        /// </summary>
        private int OffsetY
        {
            get { return (int)nudY.Value; }
            set { INIFile.SetValue("NJU_Project", "OffsetY", value.ToString()); }
        }

        /// <summary>
        /// Z方向偏移量
        /// </summary>
        private int OffsetZ
        {
            get { return (int)nudZ.Value; }
            set { INIFile.SetValue("NJU_Project", "OffsetZ", value.ToString()); }
        }

        /// <summary>
        /// X方向最大值
        /// </summary>
        private const int MaxX = 350000;

        /// <summary>
        /// Y方向最大值
        /// </summary>
        private const int MaxY = 350000;

        /// <summary>
        /// Z方向最大值
        /// </summary>
        private const int MaxZ = 110000;

        /// <summary>
        /// X方向倾斜的最大数值
        /// </summary>
        private const int MaxRX = 250000;

        /// <summary>
        /// Y轴方向倾斜的最大数值
        /// </summary>
        private const int MaxRY = 250000;

        /// <summary>
        /// Z轴方向旋转的最大数值
        /// </summary>
        private const int MaxRZ = 770000;

        /// <summary>
        /// 当前视图的缩放倍率
        /// </summary>
        private int _Rate = 1;

        /// <summary>
        /// 当前视图的缩放倍率
        /// </summary>
        public int Rate
        {
            get { return _Rate; }
            set
            {
                _Rate = value;
                lbRate.Text = "×" + Rate.ToString();
            }
        }

        /// <summary>
        /// 可活动的最小长度
        /// </summary>
        private double MinLength { get; set; }

        /// <summary>
        /// 记录上一次的AZ高度
        /// </summary>
        private int LastAZ { get; set; } = 0;

        /// <summary>
        /// 记录上一次的BZ高度
        /// </summary>
        private int LastBZ { get; set; } = 0;

        /// <summary>
        /// 定时刷新当前的状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Sys_Tick(object sender, EventArgs e)
        {
            if (Visible)
            {
                Tmr_Sys.Stop();

                // 计算倍率
                //int Limit = Math.Max(Math.Abs(pbxGroupA.Top - pbxGroupB.Top), Math.Abs(pbxGroupA.Left - pbxGroupB.Left));
                //if (Limit < 0.2 * MinLength && Rate < 1000) Rate *= 10;
                //else if (Limit > 0.8 * MinLength && Rate > 0.1) Rate /= 10;

                // 计算A组的相对位置
                int GroupA_X = Math.Abs(TestCore.MTDevice.Axises[TestCore._GroupA_X.Index].Position) - OffsetX;
                GroupA_X = (int)(GroupA_X * ((pnlMain.Width - pbxGroupA.Width) / ((double)MaxX / Rate)));
                int GroupA_Y = Math.Abs(TestCore.MTDevice.Axises[TestCore._GroupA_Y.Index].Position) - OffsetY;
                GroupA_Y = (int)(GroupA_Y * ((pnlMain.Height - pbxGroupA.Height) / ((double)MaxY / Rate)));
                pbxGroupA.Top = (TestCore._GroupA_Y.Axis_Rev ? GroupA_Y : pnlMain.Height - GroupA_Y) / Rate;
                pbxGroupA.Left = (TestCore._GroupA_X.Axis_Rev ? GroupA_X : pnlMain.Width - GroupA_X) / Rate;

                // 计算A组的相对位置
                int GroupB_X = Math.Abs(TestCore.MTDevice.Axises[TestCore._GroupB_X.Index].Position);
                GroupB_X = (int)(GroupB_X * ((pnlMain.Width - pbxGroupB.Width) / ((double)MaxX / Rate)));
                int GroupB_Y = Math.Abs(TestCore.MTDevice.Axises[TestCore._GroupB_Y.Index].Position);
                GroupB_Y = (int)(GroupB_Y * ((pnlMain.Height - pbxGroupB.Height) / ((double)MaxY / Rate)));
                pbxGroupB.Top = (TestCore._GroupB_Y.Axis_Rev ? GroupB_Y : pnlMain.Height - GroupB_Y) / Rate;
                pbxGroupB.Left = (TestCore._GroupB_X.Axis_Rev ? GroupB_X : pnlMain.Width - GroupB_X) / Rate;

                // 计算A组Z轴位置
                int GroupA_Z = Math.Abs(TestCore.MTDevice.Axises[TestCore._GroupA_Z.Index].Position) - OffsetZ;
                GroupA_Z = (int)(GroupA_Z * ((pnlZ.Height) / (double)MaxZ));
                GroupA_Z = TestCore._GroupA_Z.Axis_Rev ? GroupA_Z : (pnlZ.Height >> 1) - GroupA_Z;
                if (LastAZ != GroupA_Z)
                {
                    LastAZ = GroupA_Z;
                    pbxZA.Height = LastAZ;
                    pbxZA.BringToFront();
                }


                // 计算B组Z轴位置
                int GroupB_Z = Math.Abs(TestCore.MTDevice.Axises[TestCore._GroupB_Z.Index].Position);
                GroupB_Z = (int)(GroupB_Z * ((pnlZ.Height) / (double)MaxZ));
                GroupB_Z = TestCore._GroupB_Z.Axis_Rev ? GroupB_Z : (pnlZ.Height >> 1) - GroupB_Z;
                if (LastBZ != GroupB_Z)
                {
                    LastBZ = GroupB_Z;
                    pbxZB.Height = LastBZ;
                    pbxZA.BringToFront();
                }

                // 计算X组倾斜
                double Rotation_X = TestCore.MTDevice.Axises[TestCore._Rotation_X.Index].Position;
                Rotation_X -= TestCore.MTDevice.Axises[TestCore._Rotation_X.Index].ZeroPosition;
                Rotation_X = (TestCore._Rotation_X.Axis_Rev ? -Rotation_X : Rotation_X) / MaxRX;
                pbxXR.Width = (pnlXR.Width >> 1) + (int)(pnlXR.Width * Rotation_X);
                lbRXValue.Text = (Rotation_X+0.5).ToString("0.00%");

                // 计算Y组倾斜
                double Rotation_Y = TestCore.MTDevice.Axises[TestCore._Rotation_Y.Index].Position;
                Rotation_Y -= TestCore.MTDevice.Axises[TestCore._Rotation_Y.Index].ZeroPosition;
                Rotation_Y = (TestCore._Rotation_Y.Axis_Rev ? -Rotation_Y : Rotation_Y) / MaxRY;
                pbxYR.Width = (pnlYR.Width >> 1) + (int)(pnlYR.Width * Rotation_Y);
                lbRYValue.Text = (Rotation_Y + 0.5).ToString("0.00%");

                // 计算旋转平台数据
                double Rotation_Z = Math.Abs(TestCore.MTDevice.Axises[TestCore._Rotation_Z.Index].Position);
                double Angle = 360 * (Rotation_Z / MaxRZ);
                lbZR.Text = "--角度--\r\n" + Angle.ToString("0.00°");

                Tmr_Sys.Start();
            }
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            OffsetX = (int)nudX.Value;
            OffsetY = (int)nudY.Value;
            OffsetZ = (int)nudZ.Value;
        }

        /// <summary>
        /// 点击图标切换状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxGroupA_Click(object sender, EventArgs e)
        {
            if (sender is Control Item)
                Item.BringToFront();
        }

    }
}
