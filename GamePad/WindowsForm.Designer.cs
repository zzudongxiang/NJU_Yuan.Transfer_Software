namespace GamePad
{
    partial class WindowsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsForm));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.pnlPOV = new System.Windows.Forms.Panel();
            this.cbx_POV = new System.Windows.Forms.ComboBox();
            this.lbPOV = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.pnlConfigRight = new System.Windows.Forms.Panel();
            this.pnlY = new System.Windows.Forms.Panel();
            this.cbx_Y = new System.Windows.Forms.ComboBox();
            this.lbY = new System.Windows.Forms.Label();
            this.pnlX = new System.Windows.Forms.Panel();
            this.cbx_X = new System.Windows.Forms.ComboBox();
            this.lbX = new System.Windows.Forms.Label();
            this.pnlRB = new System.Windows.Forms.Panel();
            this.cbx_RB = new System.Windows.Forms.ComboBox();
            this.lbRB = new System.Windows.Forms.Label();
            this.pnlRT = new System.Windows.Forms.Panel();
            this.cbx_RT = new System.Windows.Forms.ComboBox();
            this.lbRT = new System.Windows.Forms.Label();
            this.pnlConfigLeft = new System.Windows.Forms.Panel();
            this.pnlB = new System.Windows.Forms.Panel();
            this.cbx_B = new System.Windows.Forms.ComboBox();
            this.lbB = new System.Windows.Forms.Label();
            this.pnlA = new System.Windows.Forms.Panel();
            this.cbx_A = new System.Windows.Forms.ComboBox();
            this.lbA = new System.Windows.Forms.Label();
            this.pnlLB = new System.Windows.Forms.Panel();
            this.cbx_LB = new System.Windows.Forms.ComboBox();
            this.lbLB = new System.Windows.Forms.Label();
            this.pnlLT = new System.Windows.Forms.Panel();
            this.cbx_LT = new System.Windows.Forms.ComboBox();
            this.lbLT = new System.Windows.Forms.Label();
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.pnlRY = new System.Windows.Forms.Panel();
            this.cbx_RY = new System.Windows.Forms.ComboBox();
            this.lbRY = new System.Windows.Forms.Label();
            this.pnlRX = new System.Windows.Forms.Panel();
            this.cbx_RX = new System.Windows.Forms.ComboBox();
            this.lbRX = new System.Windows.Forms.Label();
            this.pnlLY = new System.Windows.Forms.Panel();
            this.cbx_LY = new System.Windows.Forms.ComboBox();
            this.lbLY = new System.Windows.Forms.Label();
            this.pnlLX = new System.Windows.Forms.Panel();
            this.cbx_LX = new System.Windows.Forms.ComboBox();
            this.lbLX = new System.Windows.Forms.Label();
            this.tabOriSlider = new System.Windows.Forms.TabPage();
            this.tbxOriSlider = new System.Windows.Forms.TextBox();
            this.tabOriDir = new System.Windows.Forms.TabPage();
            this.tbxOriDir = new System.Windows.Forms.TextBox();
            this.tabOriBtn = new System.Windows.Forms.TabPage();
            this.tbxOriBtn_2 = new System.Windows.Forms.TextBox();
            this.tbxOriBtn_1 = new System.Windows.Forms.TextBox();
            this.Tmr_Status = new System.Windows.Forms.Timer();
            this.tabMain.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.pnlPOV.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlConfigRight.SuspendLayout();
            this.pnlY.SuspendLayout();
            this.pnlX.SuspendLayout();
            this.pnlRB.SuspendLayout();
            this.pnlRT.SuspendLayout();
            this.pnlConfigLeft.SuspendLayout();
            this.pnlB.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.pnlLB.SuspendLayout();
            this.pnlLT.SuspendLayout();
            this.pnlSlider.SuspendLayout();
            this.pnlRY.SuspendLayout();
            this.pnlRX.SuspendLayout();
            this.pnlLY.SuspendLayout();
            this.pnlLX.SuspendLayout();
            this.tabOriSlider.SuspendLayout();
            this.tabOriDir.SuspendLayout();
            this.tabOriBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabConfig);
            this.tabMain.Controls.Add(this.tabOriSlider);
            this.tabMain.Controls.Add(this.tabOriDir);
            this.tabMain.Controls.Add(this.tabOriBtn);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.HotTrack = true;
            this.tabMain.Location = new System.Drawing.Point(5, 5);
            this.tabMain.Margin = new System.Windows.Forms.Padding(5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(474, 473);
            this.tabMain.TabIndex = 6;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.pnlPOV);
            this.tabConfig.Controls.Add(this.pnlConfig);
            this.tabConfig.Controls.Add(this.pnlSlider);
            this.tabConfig.Location = new System.Drawing.Point(4, 29);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(5);
            this.tabConfig.Size = new System.Drawing.Size(466, 440);
            this.tabConfig.TabIndex = 4;
            this.tabConfig.Text = "手柄配置";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // pnlPOV
            // 
            this.pnlPOV.Controls.Add(this.cbx_POV);
            this.pnlPOV.Controls.Add(this.lbPOV);
            this.pnlPOV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPOV.Location = new System.Drawing.Point(5, 268);
            this.pnlPOV.Name = "pnlPOV";
            this.pnlPOV.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlPOV.Size = new System.Drawing.Size(456, 32);
            this.pnlPOV.TabIndex = 14;
            // 
            // cbx_POV
            // 
            this.cbx_POV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_POV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_POV.FormattingEnabled = true;
            this.cbx_POV.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_POV.Location = new System.Drawing.Point(225, 2);
            this.cbx_POV.Name = "cbx_POV";
            this.cbx_POV.Size = new System.Drawing.Size(231, 27);
            this.cbx_POV.TabIndex = 7;
            // 
            // lbPOV
            // 
            this.lbPOV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPOV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPOV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPOV.Location = new System.Drawing.Point(0, 2);
            this.lbPOV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPOV.Name = "lbPOV";
            this.lbPOV.Size = new System.Drawing.Size(225, 27);
            this.lbPOV.TabIndex = 6;
            this.lbPOV.Text = "上□ 下□ 左□ 右□ >>";
            this.lbPOV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.pnlConfigRight);
            this.pnlConfig.Controls.Add(this.pnlConfigLeft);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfig.Location = new System.Drawing.Point(5, 137);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(456, 131);
            this.pnlConfig.TabIndex = 3;
            // 
            // pnlConfigRight
            // 
            this.pnlConfigRight.Controls.Add(this.pnlY);
            this.pnlConfigRight.Controls.Add(this.pnlX);
            this.pnlConfigRight.Controls.Add(this.pnlRB);
            this.pnlConfigRight.Controls.Add(this.pnlRT);
            this.pnlConfigRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConfigRight.Location = new System.Drawing.Point(231, 0);
            this.pnlConfigRight.Name = "pnlConfigRight";
            this.pnlConfigRight.Size = new System.Drawing.Size(225, 131);
            this.pnlConfigRight.TabIndex = 1;
            // 
            // pnlY
            // 
            this.pnlY.BackColor = System.Drawing.Color.Transparent;
            this.pnlY.Controls.Add(this.cbx_Y);
            this.pnlY.Controls.Add(this.lbY);
            this.pnlY.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlY.Location = new System.Drawing.Point(0, 96);
            this.pnlY.Name = "pnlY";
            this.pnlY.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlY.Size = new System.Drawing.Size(225, 32);
            this.pnlY.TabIndex = 9;
            // 
            // cbx_Y
            // 
            this.cbx_Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Y.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Y.FormattingEnabled = true;
            this.cbx_Y.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_Y.Location = new System.Drawing.Point(102, 2);
            this.cbx_Y.Name = "cbx_Y";
            this.cbx_Y.Size = new System.Drawing.Size(123, 27);
            this.cbx_Y.TabIndex = 7;
            // 
            // lbY
            // 
            this.lbY.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbY.Location = new System.Drawing.Point(0, 2);
            this.lbY.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(102, 27);
            this.lbY.TabIndex = 6;
            this.lbY.Text = "Y □->";
            this.lbY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlX
            // 
            this.pnlX.BackColor = System.Drawing.Color.LightGray;
            this.pnlX.Controls.Add(this.cbx_X);
            this.pnlX.Controls.Add(this.lbX);
            this.pnlX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlX.Location = new System.Drawing.Point(0, 64);
            this.pnlX.Name = "pnlX";
            this.pnlX.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlX.Size = new System.Drawing.Size(225, 32);
            this.pnlX.TabIndex = 8;
            // 
            // cbx_X
            // 
            this.cbx_X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_X.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_X.FormattingEnabled = true;
            this.cbx_X.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_X.Location = new System.Drawing.Point(102, 2);
            this.cbx_X.Name = "cbx_X";
            this.cbx_X.Size = new System.Drawing.Size(123, 27);
            this.cbx_X.TabIndex = 7;
            // 
            // lbX
            // 
            this.lbX.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbX.Location = new System.Drawing.Point(0, 2);
            this.lbX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(102, 27);
            this.lbX.TabIndex = 6;
            this.lbX.Text = "X □->";
            this.lbX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRB
            // 
            this.pnlRB.Controls.Add(this.cbx_RB);
            this.pnlRB.Controls.Add(this.lbRB);
            this.pnlRB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRB.Location = new System.Drawing.Point(0, 32);
            this.pnlRB.Name = "pnlRB";
            this.pnlRB.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlRB.Size = new System.Drawing.Size(225, 32);
            this.pnlRB.TabIndex = 6;
            // 
            // cbx_RB
            // 
            this.cbx_RB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_RB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_RB.FormattingEnabled = true;
            this.cbx_RB.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_RB.Location = new System.Drawing.Point(102, 2);
            this.cbx_RB.Name = "cbx_RB";
            this.cbx_RB.Size = new System.Drawing.Size(123, 27);
            this.cbx_RB.TabIndex = 7;
            // 
            // lbRB
            // 
            this.lbRB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRB.Location = new System.Drawing.Point(0, 2);
            this.lbRB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRB.Name = "lbRB";
            this.lbRB.Size = new System.Drawing.Size(102, 27);
            this.lbRB.TabIndex = 6;
            this.lbRB.Text = "RB □->";
            this.lbRB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRT
            // 
            this.pnlRT.BackColor = System.Drawing.Color.LightGray;
            this.pnlRT.Controls.Add(this.cbx_RT);
            this.pnlRT.Controls.Add(this.lbRT);
            this.pnlRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRT.Location = new System.Drawing.Point(0, 0);
            this.pnlRT.Name = "pnlRT";
            this.pnlRT.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlRT.Size = new System.Drawing.Size(225, 32);
            this.pnlRT.TabIndex = 5;
            // 
            // cbx_RT
            // 
            this.cbx_RT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_RT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_RT.FormattingEnabled = true;
            this.cbx_RT.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_RT.Location = new System.Drawing.Point(102, 2);
            this.cbx_RT.Name = "cbx_RT";
            this.cbx_RT.Size = new System.Drawing.Size(123, 27);
            this.cbx_RT.TabIndex = 7;
            // 
            // lbRT
            // 
            this.lbRT.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRT.Location = new System.Drawing.Point(0, 2);
            this.lbRT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRT.Name = "lbRT";
            this.lbRT.Size = new System.Drawing.Size(102, 27);
            this.lbRT.TabIndex = 6;
            this.lbRT.Text = "RT □->";
            this.lbRT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlConfigLeft
            // 
            this.pnlConfigLeft.Controls.Add(this.pnlB);
            this.pnlConfigLeft.Controls.Add(this.pnlA);
            this.pnlConfigLeft.Controls.Add(this.pnlLB);
            this.pnlConfigLeft.Controls.Add(this.pnlLT);
            this.pnlConfigLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlConfigLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlConfigLeft.Name = "pnlConfigLeft";
            this.pnlConfigLeft.Size = new System.Drawing.Size(225, 131);
            this.pnlConfigLeft.TabIndex = 0;
            // 
            // pnlB
            // 
            this.pnlB.BackColor = System.Drawing.Color.Transparent;
            this.pnlB.Controls.Add(this.cbx_B);
            this.pnlB.Controls.Add(this.lbB);
            this.pnlB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlB.Location = new System.Drawing.Point(0, 96);
            this.pnlB.Name = "pnlB";
            this.pnlB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.pnlB.Size = new System.Drawing.Size(225, 32);
            this.pnlB.TabIndex = 9;
            // 
            // cbx_B
            // 
            this.cbx_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_B.FormattingEnabled = true;
            this.cbx_B.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_B.Location = new System.Drawing.Point(104, 2);
            this.cbx_B.Name = "cbx_B";
            this.cbx_B.Size = new System.Drawing.Size(119, 27);
            this.cbx_B.TabIndex = 7;
            // 
            // lbB
            // 
            this.lbB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbB.Location = new System.Drawing.Point(2, 2);
            this.lbB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(102, 27);
            this.lbB.TabIndex = 6;
            this.lbB.Text = "B □->";
            this.lbB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlA
            // 
            this.pnlA.BackColor = System.Drawing.Color.LightGray;
            this.pnlA.Controls.Add(this.cbx_A);
            this.pnlA.Controls.Add(this.lbA);
            this.pnlA.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlA.Location = new System.Drawing.Point(0, 64);
            this.pnlA.Name = "pnlA";
            this.pnlA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.pnlA.Size = new System.Drawing.Size(225, 32);
            this.pnlA.TabIndex = 8;
            // 
            // cbx_A
            // 
            this.cbx_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_A.FormattingEnabled = true;
            this.cbx_A.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_A.Location = new System.Drawing.Point(104, 2);
            this.cbx_A.Name = "cbx_A";
            this.cbx_A.Size = new System.Drawing.Size(119, 27);
            this.cbx_A.TabIndex = 7;
            // 
            // lbA
            // 
            this.lbA.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbA.Location = new System.Drawing.Point(2, 2);
            this.lbA.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(102, 27);
            this.lbA.TabIndex = 6;
            this.lbA.Text = "A □->";
            this.lbA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLB
            // 
            this.pnlLB.Controls.Add(this.cbx_LB);
            this.pnlLB.Controls.Add(this.lbLB);
            this.pnlLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLB.Location = new System.Drawing.Point(0, 32);
            this.pnlLB.Name = "pnlLB";
            this.pnlLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.pnlLB.Size = new System.Drawing.Size(225, 32);
            this.pnlLB.TabIndex = 6;
            // 
            // cbx_LB
            // 
            this.cbx_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_LB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LB.FormattingEnabled = true;
            this.cbx_LB.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_LB.Location = new System.Drawing.Point(104, 2);
            this.cbx_LB.Name = "cbx_LB";
            this.cbx_LB.Size = new System.Drawing.Size(119, 27);
            this.cbx_LB.TabIndex = 7;
            // 
            // lbLB
            // 
            this.lbLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLB.Location = new System.Drawing.Point(2, 2);
            this.lbLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLB.Name = "lbLB";
            this.lbLB.Size = new System.Drawing.Size(102, 27);
            this.lbLB.TabIndex = 6;
            this.lbLB.Text = "LB □->";
            this.lbLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLT
            // 
            this.pnlLT.BackColor = System.Drawing.Color.LightGray;
            this.pnlLT.Controls.Add(this.cbx_LT);
            this.pnlLT.Controls.Add(this.lbLT);
            this.pnlLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLT.Location = new System.Drawing.Point(0, 0);
            this.pnlLT.Name = "pnlLT";
            this.pnlLT.Padding = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.pnlLT.Size = new System.Drawing.Size(225, 32);
            this.pnlLT.TabIndex = 5;
            // 
            // cbx_LT
            // 
            this.cbx_LT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_LT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LT.FormattingEnabled = true;
            this.cbx_LT.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_LT.Location = new System.Drawing.Point(104, 2);
            this.cbx_LT.Name = "cbx_LT";
            this.cbx_LT.Size = new System.Drawing.Size(119, 27);
            this.cbx_LT.TabIndex = 7;
            // 
            // lbLT
            // 
            this.lbLT.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLT.Location = new System.Drawing.Point(2, 2);
            this.lbLT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLT.Name = "lbLT";
            this.lbLT.Size = new System.Drawing.Size(102, 27);
            this.lbLT.TabIndex = 6;
            this.lbLT.Text = "LT □->";
            this.lbLT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSlider
            // 
            this.pnlSlider.Controls.Add(this.pnlRY);
            this.pnlSlider.Controls.Add(this.pnlRX);
            this.pnlSlider.Controls.Add(this.pnlLY);
            this.pnlSlider.Controls.Add(this.pnlLX);
            this.pnlSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSlider.Location = new System.Drawing.Point(5, 5);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(456, 132);
            this.pnlSlider.TabIndex = 2;
            // 
            // pnlRY
            // 
            this.pnlRY.Controls.Add(this.cbx_RY);
            this.pnlRY.Controls.Add(this.lbRY);
            this.pnlRY.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRY.Location = new System.Drawing.Point(0, 96);
            this.pnlRY.Name = "pnlRY";
            this.pnlRY.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlRY.Size = new System.Drawing.Size(456, 32);
            this.pnlRY.TabIndex = 13;
            // 
            // cbx_RY
            // 
            this.cbx_RY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_RY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_RY.FormattingEnabled = true;
            this.cbx_RY.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_RY.Location = new System.Drawing.Point(220, 2);
            this.cbx_RY.Name = "cbx_RY";
            this.cbx_RY.Size = new System.Drawing.Size(236, 27);
            this.cbx_RY.TabIndex = 7;
            // 
            // lbRY
            // 
            this.lbRY.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRY.Location = new System.Drawing.Point(0, 2);
            this.lbRY.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRY.Name = "lbRY";
            this.lbRY.Size = new System.Drawing.Size(220, 27);
            this.lbRY.TabIndex = 6;
            this.lbRY.Text = "Right Y (0.000) ->";
            this.lbRY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRX
            // 
            this.pnlRX.BackColor = System.Drawing.Color.LightGray;
            this.pnlRX.Controls.Add(this.cbx_RX);
            this.pnlRX.Controls.Add(this.lbRX);
            this.pnlRX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRX.Location = new System.Drawing.Point(0, 64);
            this.pnlRX.Name = "pnlRX";
            this.pnlRX.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlRX.Size = new System.Drawing.Size(456, 32);
            this.pnlRX.TabIndex = 12;
            // 
            // cbx_RX
            // 
            this.cbx_RX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_RX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_RX.FormattingEnabled = true;
            this.cbx_RX.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_RX.Location = new System.Drawing.Point(220, 2);
            this.cbx_RX.Name = "cbx_RX";
            this.cbx_RX.Size = new System.Drawing.Size(236, 27);
            this.cbx_RX.TabIndex = 7;
            // 
            // lbRX
            // 
            this.lbRX.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRX.Location = new System.Drawing.Point(0, 2);
            this.lbRX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRX.Name = "lbRX";
            this.lbRX.Size = new System.Drawing.Size(220, 27);
            this.lbRX.TabIndex = 6;
            this.lbRX.Text = "Right X (0.000) ->";
            this.lbRX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLY
            // 
            this.pnlLY.Controls.Add(this.cbx_LY);
            this.pnlLY.Controls.Add(this.lbLY);
            this.pnlLY.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLY.Location = new System.Drawing.Point(0, 32);
            this.pnlLY.Name = "pnlLY";
            this.pnlLY.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlLY.Size = new System.Drawing.Size(456, 32);
            this.pnlLY.TabIndex = 11;
            // 
            // cbx_LY
            // 
            this.cbx_LY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_LY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LY.FormattingEnabled = true;
            this.cbx_LY.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_LY.Location = new System.Drawing.Point(220, 2);
            this.cbx_LY.Name = "cbx_LY";
            this.cbx_LY.Size = new System.Drawing.Size(236, 27);
            this.cbx_LY.TabIndex = 7;
            // 
            // lbLY
            // 
            this.lbLY.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLY.Location = new System.Drawing.Point(0, 2);
            this.lbLY.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLY.Name = "lbLY";
            this.lbLY.Size = new System.Drawing.Size(220, 27);
            this.lbLY.TabIndex = 6;
            this.lbLY.Text = "Left Y (0.000) ->";
            this.lbLY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLX
            // 
            this.pnlLX.BackColor = System.Drawing.Color.LightGray;
            this.pnlLX.Controls.Add(this.cbx_LX);
            this.pnlLX.Controls.Add(this.lbLX);
            this.pnlLX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLX.Location = new System.Drawing.Point(0, 0);
            this.pnlLX.Name = "pnlLX";
            this.pnlLX.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.pnlLX.Size = new System.Drawing.Size(456, 32);
            this.pnlLX.TabIndex = 10;
            // 
            // cbx_LX
            // 
            this.cbx_LX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_LX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_LX.FormattingEnabled = true;
            this.cbx_LX.Items.AddRange(new object[] {
            "Button 1"});
            this.cbx_LX.Location = new System.Drawing.Point(220, 2);
            this.cbx_LX.Name = "cbx_LX";
            this.cbx_LX.Size = new System.Drawing.Size(236, 27);
            this.cbx_LX.TabIndex = 7;
            // 
            // lbLX
            // 
            this.lbLX.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbLX.Location = new System.Drawing.Point(0, 2);
            this.lbLX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbLX.Name = "lbLX";
            this.lbLX.Size = new System.Drawing.Size(220, 27);
            this.lbLX.TabIndex = 6;
            this.lbLX.Text = "Left X (0.000) ->";
            this.lbLX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabOriSlider
            // 
            this.tabOriSlider.Controls.Add(this.tbxOriSlider);
            this.tabOriSlider.Font = new System.Drawing.Font("宋体", 9F);
            this.tabOriSlider.Location = new System.Drawing.Point(4, 29);
            this.tabOriSlider.Margin = new System.Windows.Forms.Padding(5);
            this.tabOriSlider.Name = "tabOriSlider";
            this.tabOriSlider.Padding = new System.Windows.Forms.Padding(5);
            this.tabOriSlider.Size = new System.Drawing.Size(466, 440);
            this.tabOriSlider.TabIndex = 0;
            this.tabOriSlider.Text = "手柄摇杆";
            this.tabOriSlider.UseVisualStyleBackColor = true;
            // 
            // tbxOriSlider
            // 
            this.tbxOriSlider.BackColor = System.Drawing.Color.Black;
            this.tbxOriSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOriSlider.Font = new System.Drawing.Font("宋体", 14F);
            this.tbxOriSlider.ForeColor = System.Drawing.Color.Lime;
            this.tbxOriSlider.Location = new System.Drawing.Point(5, 5);
            this.tbxOriSlider.Multiline = true;
            this.tbxOriSlider.Name = "tbxOriSlider";
            this.tbxOriSlider.ReadOnly = true;
            this.tbxOriSlider.Size = new System.Drawing.Size(456, 430);
            this.tbxOriSlider.TabIndex = 2;
            this.tbxOriSlider.TabStop = false;
            // 
            // tabOriDir
            // 
            this.tabOriDir.Controls.Add(this.tbxOriDir);
            this.tabOriDir.Location = new System.Drawing.Point(4, 29);
            this.tabOriDir.Margin = new System.Windows.Forms.Padding(5);
            this.tabOriDir.Name = "tabOriDir";
            this.tabOriDir.Padding = new System.Windows.Forms.Padding(5);
            this.tabOriDir.Size = new System.Drawing.Size(466, 440);
            this.tabOriDir.TabIndex = 1;
            this.tabOriDir.Text = "方向&滑杆";
            this.tabOriDir.UseVisualStyleBackColor = true;
            // 
            // tbxOriDir
            // 
            this.tbxOriDir.BackColor = System.Drawing.Color.Black;
            this.tbxOriDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxOriDir.ForeColor = System.Drawing.Color.Lime;
            this.tbxOriDir.Location = new System.Drawing.Point(5, 5);
            this.tbxOriDir.Multiline = true;
            this.tbxOriDir.Name = "tbxOriDir";
            this.tbxOriDir.ReadOnly = true;
            this.tbxOriDir.Size = new System.Drawing.Size(456, 430);
            this.tbxOriDir.TabIndex = 2;
            this.tbxOriDir.TabStop = false;
            // 
            // tabOriBtn
            // 
            this.tabOriBtn.Controls.Add(this.tbxOriBtn_2);
            this.tabOriBtn.Controls.Add(this.tbxOriBtn_1);
            this.tabOriBtn.Location = new System.Drawing.Point(4, 29);
            this.tabOriBtn.Name = "tabOriBtn";
            this.tabOriBtn.Padding = new System.Windows.Forms.Padding(5);
            this.tabOriBtn.Size = new System.Drawing.Size(466, 440);
            this.tabOriBtn.TabIndex = 2;
            this.tabOriBtn.Text = "手柄按键";
            this.tabOriBtn.UseVisualStyleBackColor = true;
            // 
            // tbxOriBtn_2
            // 
            this.tbxOriBtn_2.BackColor = System.Drawing.Color.Black;
            this.tbxOriBtn_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxOriBtn_2.ForeColor = System.Drawing.Color.Lime;
            this.tbxOriBtn_2.Location = new System.Drawing.Point(241, 5);
            this.tbxOriBtn_2.Multiline = true;
            this.tbxOriBtn_2.Name = "tbxOriBtn_2";
            this.tbxOriBtn_2.ReadOnly = true;
            this.tbxOriBtn_2.Size = new System.Drawing.Size(220, 430);
            this.tbxOriBtn_2.TabIndex = 4;
            this.tbxOriBtn_2.TabStop = false;
            // 
            // tbxOriBtn_1
            // 
            this.tbxOriBtn_1.BackColor = System.Drawing.Color.Black;
            this.tbxOriBtn_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxOriBtn_1.ForeColor = System.Drawing.Color.Lime;
            this.tbxOriBtn_1.Location = new System.Drawing.Point(5, 5);
            this.tbxOriBtn_1.Multiline = true;
            this.tbxOriBtn_1.Name = "tbxOriBtn_1";
            this.tbxOriBtn_1.ReadOnly = true;
            this.tbxOriBtn_1.Size = new System.Drawing.Size(220, 430);
            this.tbxOriBtn_1.TabIndex = 3;
            this.tbxOriBtn_1.TabStop = false;
            // 
            // Tmr_Status
            // 
            this.Tmr_Status.Enabled = true;
            this.Tmr_Status.Interval = 50;
            this.Tmr_Status.Tick += new System.EventHandler(this.Tmr_Status_Tick);
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 483);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 9999);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 39);
            this.Name = "WindowsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJU - 游戏手柄测试";
            this.TopMost = true;
            this.tabMain.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.pnlPOV.ResumeLayout(false);
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfigRight.ResumeLayout(false);
            this.pnlY.ResumeLayout(false);
            this.pnlX.ResumeLayout(false);
            this.pnlRB.ResumeLayout(false);
            this.pnlRT.ResumeLayout(false);
            this.pnlConfigLeft.ResumeLayout(false);
            this.pnlB.ResumeLayout(false);
            this.pnlA.ResumeLayout(false);
            this.pnlLB.ResumeLayout(false);
            this.pnlLT.ResumeLayout(false);
            this.pnlSlider.ResumeLayout(false);
            this.pnlRY.ResumeLayout(false);
            this.pnlRX.ResumeLayout(false);
            this.pnlLY.ResumeLayout(false);
            this.pnlLX.ResumeLayout(false);
            this.tabOriSlider.ResumeLayout(false);
            this.tabOriSlider.PerformLayout();
            this.tabOriDir.ResumeLayout(false);
            this.tabOriDir.PerformLayout();
            this.tabOriBtn.ResumeLayout(false);
            this.tabOriBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabOriSlider;
        private System.Windows.Forms.TextBox tbxOriSlider;
        private System.Windows.Forms.TabPage tabOriDir;
        private System.Windows.Forms.TextBox tbxOriDir;
        private System.Windows.Forms.TabPage tabOriBtn;
        private System.Windows.Forms.TextBox tbxOriBtn_2;
        private System.Windows.Forms.TextBox tbxOriBtn_1;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Panel pnlPOV;
        private System.Windows.Forms.ComboBox cbx_POV;
        private System.Windows.Forms.Label lbPOV;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Panel pnlConfigRight;
        private System.Windows.Forms.Panel pnlY;
        private System.Windows.Forms.ComboBox cbx_Y;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Panel pnlX;
        private System.Windows.Forms.ComboBox cbx_X;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Panel pnlRB;
        private System.Windows.Forms.ComboBox cbx_RB;
        private System.Windows.Forms.Label lbRB;
        private System.Windows.Forms.Panel pnlRT;
        private System.Windows.Forms.ComboBox cbx_RT;
        private System.Windows.Forms.Label lbRT;
        private System.Windows.Forms.Panel pnlConfigLeft;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.ComboBox cbx_B;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.ComboBox cbx_A;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Panel pnlLB;
        private System.Windows.Forms.ComboBox cbx_LB;
        private System.Windows.Forms.Label lbLB;
        private System.Windows.Forms.Panel pnlLT;
        private System.Windows.Forms.ComboBox cbx_LT;
        private System.Windows.Forms.Label lbLT;
        private System.Windows.Forms.Panel pnlSlider;
        private System.Windows.Forms.Panel pnlRY;
        private System.Windows.Forms.ComboBox cbx_RY;
        private System.Windows.Forms.Label lbRY;
        private System.Windows.Forms.Panel pnlRX;
        private System.Windows.Forms.ComboBox cbx_RX;
        private System.Windows.Forms.Label lbRX;
        private System.Windows.Forms.Panel pnlLY;
        private System.Windows.Forms.ComboBox cbx_LY;
        private System.Windows.Forms.Label lbLY;
        private System.Windows.Forms.Panel pnlLX;
        private System.Windows.Forms.ComboBox cbx_LX;
        private System.Windows.Forms.Label lbLX;
        private System.Windows.Forms.Timer Tmr_Status;
    }
}

