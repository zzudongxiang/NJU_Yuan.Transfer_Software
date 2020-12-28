namespace NJU_Project
{
    partial class ModeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeStatus));
            this.Tmr_Sys = new System.Windows.Forms.Timer(this.components);
            this.cmsSys = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlOffset = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.lbY = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.lbZ = new System.Windows.Forms.Label();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRotation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlZ = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbxGroupA = new System.Windows.Forms.Label();
            this.pbxGroupB = new System.Windows.Forms.Label();
            this.lbZR = new System.Windows.Forms.Label();
            this.pnlRXY = new System.Windows.Forms.Panel();
            this.pnlRY = new System.Windows.Forms.Panel();
            this.lbRYValue = new System.Windows.Forms.Label();
            this.lbYR = new System.Windows.Forms.Label();
            this.pnlRX = new System.Windows.Forms.Panel();
            this.lbRXValue = new System.Windows.Forms.Label();
            this.lbXR = new System.Windows.Forms.Label();
            this.pnlXR = new System.Windows.Forms.Panel();
            this.pnlYR = new System.Windows.Forms.Panel();
            this.隐藏HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxZA = new System.Windows.Forms.PictureBox();
            this.pbxZB = new System.Windows.Forms.PictureBox();
            this.pbxYR_ = new System.Windows.Forms.PictureBox();
            this.pbxYR = new System.Windows.Forms.PictureBox();
            this.pbxXR_ = new System.Windows.Forms.PictureBox();
            this.pbxXR = new System.Windows.Forms.PictureBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.cmsSys.SuspendLayout();
            this.pnlOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            this.pnlRotation.SuspendLayout();
            this.pnlZ.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlRXY.SuspendLayout();
            this.pnlRY.SuspendLayout();
            this.pnlRX.SuspendLayout();
            this.pnlXR.SuspendLayout();
            this.pnlYR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYR_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxXR_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxXR)).BeginInit();
            this.SuspendLayout();
            // 
            // Tmr_Sys
            // 
            this.Tmr_Sys.Enabled = true;
            this.Tmr_Sys.Interval = 50;
            this.Tmr_Sys.Tick += new System.EventHandler(this.Tmr_Sys_Tick);
            // 
            // cmsSys
            // 
            this.cmsSys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.隐藏HToolStripMenuItem});
            this.cmsSys.Name = "cmsSys";
            this.cmsSys.Size = new System.Drawing.Size(118, 26);
            // 
            // pnlOffset
            // 
            this.pnlOffset.BackColor = System.Drawing.Color.White;
            this.pnlOffset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOffset.Controls.Add(this.lbTitle);
            this.pnlOffset.Controls.Add(this.lbX);
            this.pnlOffset.Controls.Add(this.nudX);
            this.pnlOffset.Controls.Add(this.lbY);
            this.pnlOffset.Controls.Add(this.nudY);
            this.pnlOffset.Controls.Add(this.lbZ);
            this.pnlOffset.Controls.Add(this.nudZ);
            this.pnlOffset.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOffset.Location = new System.Drawing.Point(5, 5);
            this.pnlOffset.Name = "pnlOffset";
            this.pnlOffset.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOffset.Size = new System.Drawing.Size(535, 38);
            this.pnlOffset.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.Location = new System.Drawing.Point(3, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(152, 30);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "相对位置偏移量:";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbX
            // 
            this.lbX.AutoEllipsis = true;
            this.lbX.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbX.Location = new System.Drawing.Point(155, 3);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(25, 30);
            this.lbX.TabIndex = 12;
            this.lbX.Text = "X";
            this.lbX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudX
            // 
            this.nudX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudX.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudX.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudX.Location = new System.Drawing.Point(180, 3);
            this.nudX.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(100, 29);
            this.nudX.TabIndex = 11;
            this.nudX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudX.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // lbY
            // 
            this.lbY.AutoEllipsis = true;
            this.lbY.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbY.Location = new System.Drawing.Point(280, 3);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(25, 30);
            this.lbY.TabIndex = 10;
            this.lbY.Text = "Y";
            this.lbY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudY
            // 
            this.nudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudY.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudY.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudY.Location = new System.Drawing.Point(305, 3);
            this.nudY.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(100, 29);
            this.nudY.TabIndex = 9;
            this.nudY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudY.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // lbZ
            // 
            this.lbZ.AutoEllipsis = true;
            this.lbZ.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbZ.Location = new System.Drawing.Point(405, 3);
            this.lbZ.Name = "lbZ";
            this.lbZ.Size = new System.Drawing.Size(25, 30);
            this.lbZ.TabIndex = 8;
            this.lbZ.Text = "Z";
            this.lbZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudZ
            // 
            this.nudZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudZ.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudZ.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudZ.Location = new System.Drawing.Point(430, 3);
            this.nudZ.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudZ.Minimum = new decimal(new int[] {
            500000,
            0,
            0,
            -2147483648});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(100, 29);
            this.nudZ.TabIndex = 7;
            this.nudZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudZ.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 5);
            this.label2.TabIndex = 10;
            // 
            // pnlRotation
            // 
            this.pnlRotation.BackColor = System.Drawing.Color.White;
            this.pnlRotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRotation.Controls.Add(this.pnlRXY);
            this.pnlRotation.Controls.Add(this.lbZR);
            this.pnlRotation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRotation.Location = new System.Drawing.Point(5, 552);
            this.pnlRotation.Name = "pnlRotation";
            this.pnlRotation.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRotation.Size = new System.Drawing.Size(535, 66);
            this.pnlRotation.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(5, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 5);
            this.label3.TabIndex = 18;
            // 
            // pnlZ
            // 
            this.pnlZ.BackColor = System.Drawing.Color.White;
            this.pnlZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZ.Controls.Add(this.pbxZA);
            this.pnlZ.Controls.Add(this.pbxZB);
            this.pnlZ.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlZ.Location = new System.Drawing.Point(510, 48);
            this.pnlZ.Name = "pnlZ";
            this.pnlZ.Size = new System.Drawing.Size(30, 499);
            this.pnlZ.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(505, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(5, 499);
            this.label1.TabIndex = 20;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lbRate);
            this.pnlMain.Controls.Add(this.pbxGroupA);
            this.pnlMain.Controls.Add(this.pbxGroupB);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 48);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(500, 499);
            this.pnlMain.TabIndex = 21;
            // 
            // pbxGroupA
            // 
            this.pbxGroupA.AutoEllipsis = true;
            this.pbxGroupA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbxGroupA.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbxGroupA.Location = new System.Drawing.Point(140, 133);
            this.pbxGroupA.Name = "pbxGroupA";
            this.pbxGroupA.Size = new System.Drawing.Size(50, 50);
            this.pbxGroupA.TabIndex = 9;
            this.pbxGroupA.Text = "A组";
            this.pbxGroupA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pbxGroupA.Click += new System.EventHandler(this.pbxGroupA_Click);
            // 
            // pbxGroupB
            // 
            this.pbxGroupB.AutoEllipsis = true;
            this.pbxGroupB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbxGroupB.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbxGroupB.Location = new System.Drawing.Point(204, 197);
            this.pbxGroupB.Name = "pbxGroupB";
            this.pbxGroupB.Size = new System.Drawing.Size(50, 50);
            this.pbxGroupB.TabIndex = 8;
            this.pbxGroupB.Text = "B组";
            this.pbxGroupB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pbxGroupB.Click += new System.EventHandler(this.pbxGroupA_Click);
            // 
            // lbZR
            // 
            this.lbZR.AutoEllipsis = true;
            this.lbZR.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbZR.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbZR.Location = new System.Drawing.Point(409, 3);
            this.lbZR.Name = "lbZR";
            this.lbZR.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbZR.Size = new System.Drawing.Size(121, 58);
            this.lbZR.TabIndex = 25;
            this.lbZR.Text = "旋转: \r\n000.00°";
            this.lbZR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRXY
            // 
            this.pnlRXY.Controls.Add(this.pnlRY);
            this.pnlRXY.Controls.Add(this.pnlRX);
            this.pnlRXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRXY.Location = new System.Drawing.Point(3, 3);
            this.pnlRXY.Name = "pnlRXY";
            this.pnlRXY.Size = new System.Drawing.Size(406, 58);
            this.pnlRXY.TabIndex = 26;
            // 
            // pnlRY
            // 
            this.pnlRY.BackColor = System.Drawing.Color.White;
            this.pnlRY.Controls.Add(this.pnlYR);
            this.pnlRY.Controls.Add(this.lbRYValue);
            this.pnlRY.Controls.Add(this.lbYR);
            this.pnlRY.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRY.Location = new System.Drawing.Point(0, 29);
            this.pnlRY.Name = "pnlRY";
            this.pnlRY.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRY.Size = new System.Drawing.Size(406, 29);
            this.pnlRY.TabIndex = 16;
            // 
            // lbRYValue
            // 
            this.lbRYValue.AutoEllipsis = true;
            this.lbRYValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbRYValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRYValue.Location = new System.Drawing.Point(293, 3);
            this.lbRYValue.Name = "lbRYValue";
            this.lbRYValue.Size = new System.Drawing.Size(110, 23);
            this.lbRYValue.TabIndex = 23;
            this.lbRYValue.Text = "+000.00%";
            this.lbRYValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbYR
            // 
            this.lbYR.AutoEllipsis = true;
            this.lbYR.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbYR.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbYR.Location = new System.Drawing.Point(3, 3);
            this.lbYR.Name = "lbYR";
            this.lbYR.Size = new System.Drawing.Size(80, 23);
            this.lbYR.TabIndex = 21;
            this.lbYR.Text = "Y倾斜:";
            this.lbYR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRX
            // 
            this.pnlRX.BackColor = System.Drawing.Color.White;
            this.pnlRX.Controls.Add(this.pnlXR);
            this.pnlRX.Controls.Add(this.lbRXValue);
            this.pnlRX.Controls.Add(this.lbXR);
            this.pnlRX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRX.Location = new System.Drawing.Point(0, 0);
            this.pnlRX.Name = "pnlRX";
            this.pnlRX.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRX.Size = new System.Drawing.Size(406, 29);
            this.pnlRX.TabIndex = 15;
            // 
            // lbRXValue
            // 
            this.lbRXValue.AutoEllipsis = true;
            this.lbRXValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbRXValue.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRXValue.Location = new System.Drawing.Point(293, 3);
            this.lbRXValue.Name = "lbRXValue";
            this.lbRXValue.Size = new System.Drawing.Size(110, 23);
            this.lbRXValue.TabIndex = 21;
            this.lbRXValue.Text = "+000.00%";
            this.lbRXValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbXR
            // 
            this.lbXR.AutoEllipsis = true;
            this.lbXR.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbXR.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbXR.Location = new System.Drawing.Point(3, 3);
            this.lbXR.Name = "lbXR";
            this.lbXR.Size = new System.Drawing.Size(80, 23);
            this.lbXR.TabIndex = 14;
            this.lbXR.Text = "X倾斜:";
            this.lbXR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlXR
            // 
            this.pnlXR.BackColor = System.Drawing.Color.White;
            this.pnlXR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlXR.Controls.Add(this.pbxXR_);
            this.pnlXR.Controls.Add(this.pbxXR);
            this.pnlXR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlXR.Location = new System.Drawing.Point(83, 3);
            this.pnlXR.Name = "pnlXR";
            this.pnlXR.Size = new System.Drawing.Size(210, 23);
            this.pnlXR.TabIndex = 22;
            // 
            // pnlYR
            // 
            this.pnlYR.BackColor = System.Drawing.Color.White;
            this.pnlYR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYR.Controls.Add(this.pbxYR_);
            this.pnlYR.Controls.Add(this.pbxYR);
            this.pnlYR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYR.Location = new System.Drawing.Point(83, 3);
            this.pnlYR.Name = "pnlYR";
            this.pnlYR.Size = new System.Drawing.Size(210, 23);
            this.pnlYR.TabIndex = 24;
            // 
            // 隐藏HToolStripMenuItem
            // 
            this.隐藏HToolStripMenuItem.Image = global::NJU_Project.Properties.Resources.Hide_Black;
            this.隐藏HToolStripMenuItem.Name = "隐藏HToolStripMenuItem";
            this.隐藏HToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.隐藏HToolStripMenuItem.Text = "隐藏(&H)";
            this.隐藏HToolStripMenuItem.Click += new System.EventHandler(this.隐藏HToolStripMenuItem_Click);
            // 
            // pbxZA
            // 
            this.pbxZA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbxZA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxZA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxZA.Location = new System.Drawing.Point(0, 0);
            this.pbxZA.Name = "pbxZA";
            this.pbxZA.Size = new System.Drawing.Size(28, 197);
            this.pbxZA.TabIndex = 2;
            this.pbxZA.TabStop = false;
            this.pbxZA.Click += new System.EventHandler(this.pbxGroupA_Click);
            // 
            // pbxZB
            // 
            this.pbxZB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbxZB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxZB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbxZB.Location = new System.Drawing.Point(0, 331);
            this.pbxZB.Name = "pbxZB";
            this.pbxZB.Size = new System.Drawing.Size(28, 166);
            this.pbxZB.TabIndex = 1;
            this.pbxZB.TabStop = false;
            this.pbxZB.Click += new System.EventHandler(this.pbxGroupA_Click);
            // 
            // pbxYR_
            // 
            this.pbxYR_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbxYR_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxYR_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxYR_.Location = new System.Drawing.Point(45, 0);
            this.pbxYR_.Name = "pbxYR_";
            this.pbxYR_.Size = new System.Drawing.Size(163, 21);
            this.pbxYR_.TabIndex = 3;
            this.pbxYR_.TabStop = false;
            // 
            // pbxYR
            // 
            this.pbxYR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbxYR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxYR.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxYR.Location = new System.Drawing.Point(0, 0);
            this.pbxYR.Name = "pbxYR";
            this.pbxYR.Size = new System.Drawing.Size(45, 21);
            this.pbxYR.TabIndex = 2;
            this.pbxYR.TabStop = false;
            // 
            // pbxXR_
            // 
            this.pbxXR_.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbxXR_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxXR_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxXR_.Location = new System.Drawing.Point(58, 0);
            this.pbxXR_.Name = "pbxXR_";
            this.pbxXR_.Size = new System.Drawing.Size(150, 21);
            this.pbxXR_.TabIndex = 18;
            this.pbxXR_.TabStop = false;
            // 
            // pbxXR
            // 
            this.pbxXR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbxXR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxXR.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxXR.Location = new System.Drawing.Point(0, 0);
            this.pbxXR.Name = "pbxXR";
            this.pbxXR.Size = new System.Drawing.Size(58, 21);
            this.pbxXR.TabIndex = 17;
            this.pbxXR.TabStop = false;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.BackColor = System.Drawing.Color.Transparent;
            this.lbRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRate.Location = new System.Drawing.Point(0, 0);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(38, 26);
            this.lbRate.TabIndex = 10;
            this.lbRate.Text = "×1";
            this.lbRate.Visible = false;
            // 
            // ModeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 623);
            this.ContextMenuStrip = this.cmsSys;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlRotation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlOffset);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModeStatus";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJU - 转移台系统状态";
            this.TopMost = true;
            this.cmsSys.ResumeLayout(false);
            this.pnlOffset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            this.pnlRotation.ResumeLayout(false);
            this.pnlZ.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlRXY.ResumeLayout(false);
            this.pnlRY.ResumeLayout(false);
            this.pnlRX.ResumeLayout(false);
            this.pnlXR.ResumeLayout(false);
            this.pnlYR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxZA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYR_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxXR_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxXR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Tmr_Sys;
        private System.Windows.Forms.ContextMenuStrip cmsSys;
        private System.Windows.Forms.ToolStripMenuItem 隐藏HToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbZ;
        private System.Windows.Forms.NumericUpDown nudZ;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlRotation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlZ;
        private System.Windows.Forms.PictureBox pbxZA;
        private System.Windows.Forms.PictureBox pbxZB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label pbxGroupA;
        private System.Windows.Forms.Label pbxGroupB;
        private System.Windows.Forms.Label lbZR;
        private System.Windows.Forms.Panel pnlRXY;
        private System.Windows.Forms.Panel pnlRY;
        private System.Windows.Forms.Panel pnlYR;
        private System.Windows.Forms.PictureBox pbxYR_;
        private System.Windows.Forms.PictureBox pbxYR;
        private System.Windows.Forms.Label lbRYValue;
        private System.Windows.Forms.Label lbYR;
        private System.Windows.Forms.Panel pnlRX;
        private System.Windows.Forms.Panel pnlXR;
        private System.Windows.Forms.PictureBox pbxXR_;
        private System.Windows.Forms.PictureBox pbxXR;
        private System.Windows.Forms.Label lbRXValue;
        private System.Windows.Forms.Label lbXR;
        private System.Windows.Forms.Label lbRate;
    }
}