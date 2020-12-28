namespace NJU_Project
{
    partial class WindowsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsForm));
            this.Tmr_Button = new System.Windows.Forms.Timer(this.components);
            this.ntfSys = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsSys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑相关属性SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.综合状态显示MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轴状态显示AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pbxTitle = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbRotation = new System.Windows.Forms.Label();
            this.lbGroupB = new System.Windows.Forms.Label();
            this.lbGroupA = new System.Windows.Forms.Label();
            this.lbZero = new System.Windows.Forms.Label();
            this.cmsSys.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tmr_Button
            // 
            this.Tmr_Button.Enabled = true;
            this.Tmr_Button.Interval = 50;
            this.Tmr_Button.Tick += new System.EventHandler(this.Tmr_Button_Tick);
            // 
            // ntfSys
            // 
            this.ntfSys.ContextMenuStrip = this.cmsSys;
            this.ntfSys.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfSys.Icon")));
            this.ntfSys.Text = "NJU - 转移台";
            this.ntfSys.Visible = true;
            // 
            // cmsSys
            // 
            this.cmsSys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑相关属性SToolStripMenuItem,
            this.toolStripSeparator1,
            this.综合状态显示MToolStripMenuItem,
            this.轴状态显示AToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出EToolStripMenuItem});
            this.cmsSys.Name = "cmsSys";
            this.cmsSys.Size = new System.Drawing.Size(169, 104);
            this.cmsSys.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSys_Opening);
            // 
            // 编辑相关属性SToolStripMenuItem
            // 
            this.编辑相关属性SToolStripMenuItem.Image = global::NJU_Project.Properties.Resources.Setting;
            this.编辑相关属性SToolStripMenuItem.Name = "编辑相关属性SToolStripMenuItem";
            this.编辑相关属性SToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.编辑相关属性SToolStripMenuItem.Text = "编辑相关属性(&S)";
            this.编辑相关属性SToolStripMenuItem.Click += new System.EventHandler(this.编辑相关属性SToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // 综合状态显示MToolStripMenuItem
            // 
            this.综合状态显示MToolStripMenuItem.Image = global::NJU_Project.Properties.Resources.Hide_Black;
            this.综合状态显示MToolStripMenuItem.Name = "综合状态显示MToolStripMenuItem";
            this.综合状态显示MToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.综合状态显示MToolStripMenuItem.Text = "综合状态显示(&M)";
            this.综合状态显示MToolStripMenuItem.Click += new System.EventHandler(this.Tsi_Click);
            // 
            // 轴状态显示AToolStripMenuItem
            // 
            this.轴状态显示AToolStripMenuItem.Image = global::NJU_Project.Properties.Resources.Chart;
            this.轴状态显示AToolStripMenuItem.Name = "轴状态显示AToolStripMenuItem";
            this.轴状态显示AToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.轴状态显示AToolStripMenuItem.Text = "轴状态显示(&A)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Image = global::NJU_Project.Properties.Resources.Close;
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(100)))), ((int)(((byte)(241)))));
            this.pnlTitle.Controls.Add(this.pbxTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(5, 5);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTitle.Size = new System.Drawing.Size(285, 107);
            this.pnlTitle.TabIndex = 6;
            // 
            // pbxTitle
            // 
            this.pbxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxTitle.Image = global::NJU_Project.Properties.Resources.NJULogo_1;
            this.pbxTitle.Location = new System.Drawing.Point(5, 5);
            this.pbxTitle.Name = "pbxTitle";
            this.pbxTitle.Size = new System.Drawing.Size(275, 97);
            this.pbxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTitle.TabIndex = 0;
            this.pbxTitle.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(100)))), ((int)(((byte)(241)))));
            this.pnlMain.Controls.Add(this.lbRotation);
            this.pnlMain.Controls.Add(this.lbGroupB);
            this.pnlMain.Controls.Add(this.lbGroupA);
            this.pnlMain.Controls.Add(this.lbZero);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 112);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(285, 322);
            this.pnlMain.TabIndex = 7;
            // 
            // lbRotation
            // 
            this.lbRotation.AutoEllipsis = true;
            this.lbRotation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRotation.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.lbRotation.ForeColor = System.Drawing.Color.Black;
            this.lbRotation.Location = new System.Drawing.Point(0, 160);
            this.lbRotation.Name = "lbRotation";
            this.lbRotation.Size = new System.Drawing.Size(285, 40);
            this.lbRotation.TabIndex = 6;
            this.lbRotation.Text = "自由旋转";
            this.lbRotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGroupB
            // 
            this.lbGroupB.AutoEllipsis = true;
            this.lbGroupB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGroupB.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.lbGroupB.ForeColor = System.Drawing.Color.Black;
            this.lbGroupB.Location = new System.Drawing.Point(0, 120);
            this.lbGroupB.Name = "lbGroupB";
            this.lbGroupB.Size = new System.Drawing.Size(285, 40);
            this.lbGroupB.TabIndex = 5;
            this.lbGroupB.Text = "B组平移";
            this.lbGroupB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGroupA
            // 
            this.lbGroupA.AutoEllipsis = true;
            this.lbGroupA.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGroupA.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.lbGroupA.ForeColor = System.Drawing.Color.Black;
            this.lbGroupA.Location = new System.Drawing.Point(0, 80);
            this.lbGroupA.Name = "lbGroupA";
            this.lbGroupA.Size = new System.Drawing.Size(285, 40);
            this.lbGroupA.TabIndex = 4;
            this.lbGroupA.Text = "A组平移";
            this.lbGroupA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbZero
            // 
            this.lbZero.AutoEllipsis = true;
            this.lbZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(37)))), ((int)(((byte)(154)))));
            this.lbZero.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbZero.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold);
            this.lbZero.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbZero.Location = new System.Drawing.Point(0, 0);
            this.lbZero.Name = "lbZero";
            this.lbZero.Size = new System.Drawing.Size(285, 80);
            this.lbZero.TabIndex = 3;
            this.lbZero.Text = "自动复位";
            this.lbZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(27)))), ((int)(((byte)(123)))));
            this.ClientSize = new System.Drawing.Size(295, 439);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJU - 模式选择";
            this.TopMost = true;
            this.cmsSys.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTitle)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Tmr_Button;
        private System.Windows.Forms.NotifyIcon ntfSys;
        private System.Windows.Forms.ContextMenuStrip cmsSys;
        private System.Windows.Forms.ToolStripMenuItem 编辑相关属性SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.PictureBox pbxTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lbRotation;
        private System.Windows.Forms.Label lbGroupB;
        private System.Windows.Forms.Label lbGroupA;
        private System.Windows.Forms.Label lbZero;
        private System.Windows.Forms.ToolStripMenuItem 轴状态显示AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 综合状态显示MToolStripMenuItem;
    }
}