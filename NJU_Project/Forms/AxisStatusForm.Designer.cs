namespace NJU_Project
{
    partial class AxisStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxisStatusForm));
            this.cmsSys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tmr_Sys = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pgbStatus = new System.Windows.Forms.ProgressBar();
            this.lbP = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cmsSys.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsSys
            // 
            this.cmsSys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.隐藏ToolStripMenuItem});
            this.cmsSys.Name = "cmsSys";
            this.cmsSys.Size = new System.Drawing.Size(118, 26);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Image = global::NJU_Project.Properties.Resources.Hide_Black;
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.隐藏ToolStripMenuItem.Text = "隐藏(&H)";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // Tmr_Sys
            // 
            this.Tmr_Sys.Enabled = true;
            this.Tmr_Sys.Interval = 50;
            this.Tmr_Sys.Tick += new System.EventHandler(this.Tmr_Sys_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pgbStatus);
            this.pnlMain.Controls.Add(this.lbP);
            this.pnlMain.Controls.Add(this.lbTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlMain.Size = new System.Drawing.Size(409, 130);
            this.pnlMain.TabIndex = 11;
            // 
            // pgbStatus
            // 
            this.pgbStatus.ContextMenuStrip = this.cmsSys;
            this.pgbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbStatus.Location = new System.Drawing.Point(127, 39);
            this.pgbStatus.MarqueeAnimationSpeed = 20;
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(277, 86);
            this.pgbStatus.Step = 50;
            this.pgbStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbStatus.TabIndex = 14;
            this.pgbStatus.Value = 50;
            // 
            // lbP
            // 
            this.lbP.AutoEllipsis = true;
            this.lbP.AutoSize = true;
            this.lbP.BackColor = System.Drawing.Color.Transparent;
            this.lbP.ContextMenuStrip = this.cmsSys;
            this.lbP.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbP.ForeColor = System.Drawing.Color.Blue;
            this.lbP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbP.Location = new System.Drawing.Point(3, 39);
            this.lbP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(124, 21);
            this.lbP.TabIndex = 13;
            this.lbP.Text = "速度: +000000";
            this.lbP.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbP.Resize += new System.EventHandler(this.lbTitle_Resize);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.ContextMenuStrip = this.cmsSys;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitle.Location = new System.Drawing.Point(3, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(250, 39);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "A组 X轴 [Axis-1]";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTitle.Resize += new System.EventHandler(this.lbTitle_Resize);
            // 
            // AxisStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(415, 136);
            this.ContextMenuStrip = this.cmsSys;
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AxisStatusForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NJU - 轴状态";
            this.TopMost = true;
            this.cmsSys.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Tmr_Sys;
        private System.Windows.Forms.ContextMenuStrip cmsSys;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ProgressBar pgbStatus;
    }
}