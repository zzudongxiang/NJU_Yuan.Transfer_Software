namespace MTDevice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCalibrate = new System.Windows.Forms.Panel();
            this.btnInitVerifi = new System.Windows.Forms.Button();
            this.lbInit = new System.Windows.Forms.Label();
            this.nudInit = new System.Windows.Forms.NumericUpDown();
            this.pbxInit = new System.Windows.Forms.PictureBox();
            this.lbTitleCalibrate = new System.Windows.Forms.Label();
            this.pnlZero = new System.Windows.Forms.Panel();
            this.cbxPosZero = new System.Windows.Forms.CheckBox();
            this.btnHalt = new System.Windows.Forms.Button();
            this.lbZeroSplit = new System.Windows.Forms.Label();
            this.btnZero = new System.Windows.Forms.Button();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.lbMoveSplit = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.nudMove = new System.Windows.Forms.NumericUpDown();
            this.lbMove = new System.Windows.Forms.Label();
            this.lbTitleTest = new System.Windows.Forms.Label();
            this.pnlAcc = new System.Windows.Forms.Panel();
            this.nudDecc = new System.Windows.Forms.NumericUpDown();
            this.lbDecc = new System.Windows.Forms.Label();
            this.nudAcc = new System.Windows.Forms.NumericUpDown();
            this.lbAcc = new System.Windows.Forms.Label();
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.tbxCaption = new System.Windows.Forms.TextBox();
            this.lbCaption = new System.Windows.Forms.Label();
            this.lbTitleConfig = new System.Windows.Forms.Label();
            this.pnlValue = new System.Windows.Forms.Panel();
            this.lbP = new System.Windows.Forms.Label();
            this.lbV = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.cbxPos = new System.Windows.Forms.CheckBox();
            this.cbxZero = new System.Windows.Forms.CheckBox();
            this.cbxNeg = new System.Windows.Forms.CheckBox();
            this.cbxRun = new System.Windows.Forms.CheckBox();
            this.lbTitlePreview = new System.Windows.Forms.Label();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.pbxSaveAll = new System.Windows.Forms.PictureBox();
            this.lbSaveAll = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbSplit = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.pnlSelectAxis = new System.Windows.Forms.Panel();
            this.cbxSelectAxis = new System.Windows.Forms.ComboBox();
            this.lbSelectAxis = new System.Windows.Forms.Label();
            this.Tmr_Data = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlCalibrate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInit)).BeginInit();
            this.pnlZero.SuspendLayout();
            this.pnlMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMove)).BeginInit();
            this.pnlAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcc)).BeginInit();
            this.pnlCaption.SuspendLayout();
            this.pnlValue.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaveAll)).BeginInit();
            this.pnlSelectAxis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pnlCalibrate);
            this.pnlMain.Controls.Add(this.lbTitleCalibrate);
            this.pnlMain.Controls.Add(this.pnlZero);
            this.pnlMain.Controls.Add(this.pnlMove);
            this.pnlMain.Controls.Add(this.lbTitleTest);
            this.pnlMain.Controls.Add(this.pnlAcc);
            this.pnlMain.Controls.Add(this.pnlCaption);
            this.pnlMain.Controls.Add(this.lbTitleConfig);
            this.pnlMain.Controls.Add(this.pnlValue);
            this.pnlMain.Controls.Add(this.pnlStatus);
            this.pnlMain.Controls.Add(this.lbTitlePreview);
            this.pnlMain.Controls.Add(this.pnlSave);
            this.pnlMain.Controls.Add(this.pnlSelectAxis);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(434, 461);
            this.pnlMain.TabIndex = 10;
            // 
            // pnlCalibrate
            // 
            this.pnlCalibrate.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCalibrate.Controls.Add(this.btnInitVerifi);
            this.pnlCalibrate.Controls.Add(this.lbInit);
            this.pnlCalibrate.Controls.Add(this.nudInit);
            this.pnlCalibrate.Controls.Add(this.pbxInit);
            this.pnlCalibrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCalibrate.Location = new System.Drawing.Point(0, 362);
            this.pnlCalibrate.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCalibrate.Name = "pnlCalibrate";
            this.pnlCalibrate.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.pnlCalibrate.Size = new System.Drawing.Size(432, 39);
            this.pnlCalibrate.TabIndex = 34;
            // 
            // btnInitVerifi
            // 
            this.btnInitVerifi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInitVerifi.Location = new System.Drawing.Point(8, 5);
            this.btnInitVerifi.Name = "btnInitVerifi";
            this.btnInitVerifi.Size = new System.Drawing.Size(175, 29);
            this.btnInitVerifi.TabIndex = 27;
            this.btnInitVerifi.Text = ">>验证初始位<<";
            this.btnInitVerifi.UseVisualStyleBackColor = true;
            this.btnInitVerifi.Click += new System.EventHandler(this.btnInitVerifi_Click);
            // 
            // lbInit
            // 
            this.lbInit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbInit.Font = new System.Drawing.Font("宋体", 14F);
            this.lbInit.ForeColor = System.Drawing.Color.Black;
            this.lbInit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbInit.Location = new System.Drawing.Point(205, 5);
            this.lbInit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbInit.Name = "lbInit";
            this.lbInit.Size = new System.Drawing.Size(78, 29);
            this.lbInit.TabIndex = 26;
            this.lbInit.Text = "初始位:";
            this.lbInit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudInit
            // 
            this.nudInit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudInit.Dock = System.Windows.Forms.DockStyle.Right;
            this.nudInit.Location = new System.Drawing.Point(283, 5);
            this.nudInit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudInit.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudInit.Name = "nudInit";
            this.nudInit.Size = new System.Drawing.Size(114, 29);
            this.nudInit.TabIndex = 25;
            this.nudInit.Tag = "ZeroPosition";
            this.nudInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInit.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudInit.ValueChanged += new System.EventHandler(this.Control_Leave);
            // 
            // pbxInit
            // 
            this.pbxInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxInit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxInit.Image = global::MTDevice.Properties.Resources.Import;
            this.pbxInit.Location = new System.Drawing.Point(397, 5);
            this.pbxInit.Name = "pbxInit";
            this.pbxInit.Size = new System.Drawing.Size(27, 29);
            this.pbxInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxInit.TabIndex = 24;
            this.pbxInit.TabStop = false;
            this.pbxInit.Click += new System.EventHandler(this.pbxInit_Click);
            // 
            // lbTitleCalibrate
            // 
            this.lbTitleCalibrate.BackColor = System.Drawing.Color.LightGray;
            this.lbTitleCalibrate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitleCalibrate.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleCalibrate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitleCalibrate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitleCalibrate.Location = new System.Drawing.Point(0, 335);
            this.lbTitleCalibrate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitleCalibrate.Name = "lbTitleCalibrate";
            this.lbTitleCalibrate.Size = new System.Drawing.Size(432, 27);
            this.lbTitleCalibrate.TabIndex = 33;
            this.lbTitleCalibrate.Text = "----------初始位置设置----------";
            this.lbTitleCalibrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlZero
            // 
            this.pnlZero.BackColor = System.Drawing.Color.Transparent;
            this.pnlZero.Controls.Add(this.cbxPosZero);
            this.pnlZero.Controls.Add(this.btnHalt);
            this.pnlZero.Controls.Add(this.lbZeroSplit);
            this.pnlZero.Controls.Add(this.btnZero);
            this.pnlZero.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZero.Location = new System.Drawing.Point(0, 294);
            this.pnlZero.Margin = new System.Windows.Forms.Padding(5);
            this.pnlZero.Name = "pnlZero";
            this.pnlZero.Padding = new System.Windows.Forms.Padding(8, 2, 8, 10);
            this.pnlZero.Size = new System.Drawing.Size(432, 41);
            this.pnlZero.TabIndex = 32;
            // 
            // cbxPosZero
            // 
            this.cbxPosZero.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxPosZero.Location = new System.Drawing.Point(129, 2);
            this.cbxPosZero.Name = "cbxPosZero";
            this.cbxPosZero.Size = new System.Drawing.Size(162, 29);
            this.cbxPosZero.TabIndex = 23;
            this.cbxPosZero.Text = "正向查找零位";
            this.cbxPosZero.UseVisualStyleBackColor = true;
            this.cbxPosZero.CheckedChanged += new System.EventHandler(this.cbxPosZero_CheckedChanged);
            // 
            // btnHalt
            // 
            this.btnHalt.BackColor = System.Drawing.Color.Red;
            this.btnHalt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHalt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHalt.ForeColor = System.Drawing.Color.White;
            this.btnHalt.Location = new System.Drawing.Point(342, 2);
            this.btnHalt.Name = "btnHalt";
            this.btnHalt.Size = new System.Drawing.Size(82, 29);
            this.btnHalt.TabIndex = 22;
            this.btnHalt.Tag = ">";
            this.btnHalt.Text = "停止";
            this.btnHalt.UseVisualStyleBackColor = false;
            this.btnHalt.Click += new System.EventHandler(this.btnHalt_Click);
            // 
            // lbZeroSplit
            // 
            this.lbZeroSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbZeroSplit.Font = new System.Drawing.Font("宋体", 14F);
            this.lbZeroSplit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbZeroSplit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbZeroSplit.Location = new System.Drawing.Point(118, 2);
            this.lbZeroSplit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbZeroSplit.Name = "lbZeroSplit";
            this.lbZeroSplit.Size = new System.Drawing.Size(11, 29);
            this.lbZeroSplit.TabIndex = 20;
            this.lbZeroSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnZero.Location = new System.Drawing.Point(8, 2);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(110, 29);
            this.btnZero.TabIndex = 19;
            this.btnZero.Tag = "<";
            this.btnZero.Text = "查找零位";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMove.Controls.Add(this.btnLeft);
            this.pnlMove.Controls.Add(this.lbMoveSplit);
            this.pnlMove.Controls.Add(this.btnRight);
            this.pnlMove.Controls.Add(this.nudMove);
            this.pnlMove.Controls.Add(this.lbMove);
            this.pnlMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMove.Location = new System.Drawing.Point(0, 261);
            this.pnlMove.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlMove.Size = new System.Drawing.Size(432, 33);
            this.pnlMove.TabIndex = 31;
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLeft.Location = new System.Drawing.Point(263, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 29);
            this.btnLeft.TabIndex = 18;
            this.btnLeft.Tag = "-";
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // lbMoveSplit
            // 
            this.lbMoveSplit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMoveSplit.Font = new System.Drawing.Font("宋体", 14F);
            this.lbMoveSplit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMoveSplit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMoveSplit.Location = new System.Drawing.Point(338, 2);
            this.lbMoveSplit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMoveSplit.Name = "lbMoveSplit";
            this.lbMoveSplit.Size = new System.Drawing.Size(11, 29);
            this.lbMoveSplit.TabIndex = 17;
            this.lbMoveSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.Location = new System.Drawing.Point(349, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 29);
            this.btnRight.TabIndex = 16;
            this.btnRight.Tag = "+";
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // nudMove
            // 
            this.nudMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudMove.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudMove.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMove.Location = new System.Drawing.Point(111, 2);
            this.nudMove.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMove.Name = "nudMove";
            this.nudMove.Size = new System.Drawing.Size(114, 29);
            this.nudMove.TabIndex = 12;
            this.nudMove.Tag = "Speed";
            this.nudMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMove.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMove.ValueChanged += new System.EventHandler(this.Control_Leave);
            // 
            // lbMove
            // 
            this.lbMove.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMove.Font = new System.Drawing.Font("宋体", 14F);
            this.lbMove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbMove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMove.Location = new System.Drawing.Point(8, 2);
            this.lbMove.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMove.Name = "lbMove";
            this.lbMove.Size = new System.Drawing.Size(103, 29);
            this.lbMove.TabIndex = 7;
            this.lbMove.Text = "移动速度:";
            this.lbMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitleTest
            // 
            this.lbTitleTest.BackColor = System.Drawing.Color.LightGray;
            this.lbTitleTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitleTest.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitleTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitleTest.Location = new System.Drawing.Point(0, 234);
            this.lbTitleTest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitleTest.Name = "lbTitleTest";
            this.lbTitleTest.Size = new System.Drawing.Size(432, 27);
            this.lbTitleTest.TabIndex = 30;
            this.lbTitleTest.Text = "----------电机操作测试----------";
            this.lbTitleTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAcc
            // 
            this.pnlAcc.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAcc.Controls.Add(this.nudDecc);
            this.pnlAcc.Controls.Add(this.lbDecc);
            this.pnlAcc.Controls.Add(this.nudAcc);
            this.pnlAcc.Controls.Add(this.lbAcc);
            this.pnlAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcc.Location = new System.Drawing.Point(0, 193);
            this.pnlAcc.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAcc.Name = "pnlAcc";
            this.pnlAcc.Padding = new System.Windows.Forms.Padding(8, 2, 8, 10);
            this.pnlAcc.Size = new System.Drawing.Size(432, 41);
            this.pnlAcc.TabIndex = 29;
            // 
            // nudDecc
            // 
            this.nudDecc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDecc.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudDecc.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDecc.Location = new System.Drawing.Point(307, 2);
            this.nudDecc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDecc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDecc.Name = "nudDecc";
            this.nudDecc.Size = new System.Drawing.Size(114, 29);
            this.nudDecc.TabIndex = 15;
            this.nudDecc.Tag = "Decc";
            this.nudDecc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDecc.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDecc.ValueChanged += new System.EventHandler(this.Control_Leave);
            // 
            // lbDecc
            // 
            this.lbDecc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDecc.Font = new System.Drawing.Font("宋体", 14F);
            this.lbDecc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDecc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDecc.Location = new System.Drawing.Point(225, 2);
            this.lbDecc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDecc.Name = "lbDecc";
            this.lbDecc.Size = new System.Drawing.Size(82, 29);
            this.lbDecc.TabIndex = 14;
            this.lbDecc.Text = "减速度:";
            this.lbDecc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAcc
            // 
            this.nudAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudAcc.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAcc.Location = new System.Drawing.Point(111, 2);
            this.nudAcc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAcc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAcc.Name = "nudAcc";
            this.nudAcc.Size = new System.Drawing.Size(114, 29);
            this.nudAcc.TabIndex = 13;
            this.nudAcc.Tag = "Acc";
            this.nudAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAcc.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAcc.ValueChanged += new System.EventHandler(this.Control_Leave);
            // 
            // lbAcc
            // 
            this.lbAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAcc.Font = new System.Drawing.Font("宋体", 14F);
            this.lbAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbAcc.Location = new System.Drawing.Point(8, 2);
            this.lbAcc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(103, 29);
            this.lbAcc.TabIndex = 7;
            this.lbAcc.Text = "加速度:";
            this.lbAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCaption
            // 
            this.pnlCaption.Controls.Add(this.tbxCaption);
            this.pnlCaption.Controls.Add(this.lbCaption);
            this.pnlCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCaption.Location = new System.Drawing.Point(0, 160);
            this.pnlCaption.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlCaption.Size = new System.Drawing.Size(432, 33);
            this.pnlCaption.TabIndex = 28;
            // 
            // tbxCaption
            // 
            this.tbxCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCaption.Location = new System.Drawing.Point(111, 2);
            this.tbxCaption.Name = "tbxCaption";
            this.tbxCaption.Size = new System.Drawing.Size(313, 29);
            this.tbxCaption.TabIndex = 7;
            this.tbxCaption.Tag = "Caption";
            this.tbxCaption.TextChanged += new System.EventHandler(this.Control_Leave);
            // 
            // lbCaption
            // 
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCaption.Font = new System.Drawing.Font("宋体", 14F);
            this.lbCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCaption.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCaption.Location = new System.Drawing.Point(8, 2);
            this.lbCaption.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(103, 29);
            this.lbCaption.TabIndex = 6;
            this.lbCaption.Text = "轴名称:";
            this.lbCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTitleConfig
            // 
            this.lbTitleConfig.BackColor = System.Drawing.Color.LightGray;
            this.lbTitleConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitleConfig.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitleConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitleConfig.Location = new System.Drawing.Point(0, 133);
            this.lbTitleConfig.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitleConfig.Name = "lbTitleConfig";
            this.lbTitleConfig.Size = new System.Drawing.Size(432, 27);
            this.lbTitleConfig.TabIndex = 27;
            this.lbTitleConfig.Text = "----------设备属性设置----------";
            this.lbTitleConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlValue
            // 
            this.pnlValue.Controls.Add(this.lbP);
            this.pnlValue.Controls.Add(this.lbV);
            this.pnlValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValue.Location = new System.Drawing.Point(0, 101);
            this.pnlValue.Margin = new System.Windows.Forms.Padding(5);
            this.pnlValue.Name = "pnlValue";
            this.pnlValue.Padding = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.pnlValue.Size = new System.Drawing.Size(432, 32);
            this.pnlValue.TabIndex = 26;
            // 
            // lbP
            // 
            this.lbP.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbP.Font = new System.Drawing.Font("宋体", 14F);
            this.lbP.ForeColor = System.Drawing.Color.Green;
            this.lbP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbP.Location = new System.Drawing.Point(229, 0);
            this.lbP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(195, 22);
            this.lbP.TabIndex = 7;
            this.lbP.Text = "当前位置: 0";
            this.lbP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV
            // 
            this.lbV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbV.Font = new System.Drawing.Font("宋体", 14F);
            this.lbV.ForeColor = System.Drawing.Color.Green;
            this.lbV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbV.Location = new System.Drawing.Point(8, 0);
            this.lbV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbV.Name = "lbV";
            this.lbV.Size = new System.Drawing.Size(212, 22);
            this.lbV.TabIndex = 6;
            this.lbV.Text = "当前速度: 0";
            this.lbV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.Control;
            this.pnlStatus.Controls.Add(this.cbxPos);
            this.pnlStatus.Controls.Add(this.cbxZero);
            this.pnlStatus.Controls.Add(this.cbxNeg);
            this.pnlStatus.Controls.Add(this.cbxRun);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 64);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.pnlStatus.Size = new System.Drawing.Size(432, 37);
            this.pnlStatus.TabIndex = 25;
            // 
            // cbxPos
            // 
            this.cbxPos.AutoCheck = false;
            this.cbxPos.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxPos.Location = new System.Drawing.Point(330, 5);
            this.cbxPos.Name = "cbxPos";
            this.cbxPos.Size = new System.Drawing.Size(100, 27);
            this.cbxPos.TabIndex = 3;
            this.cbxPos.Text = "正限位";
            this.cbxPos.UseVisualStyleBackColor = true;
            // 
            // cbxZero
            // 
            this.cbxZero.AutoCheck = false;
            this.cbxZero.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxZero.Location = new System.Drawing.Point(230, 5);
            this.cbxZero.Name = "cbxZero";
            this.cbxZero.Size = new System.Drawing.Size(100, 27);
            this.cbxZero.TabIndex = 2;
            this.cbxZero.Text = "零限位";
            this.cbxZero.UseVisualStyleBackColor = true;
            // 
            // cbxNeg
            // 
            this.cbxNeg.AutoCheck = false;
            this.cbxNeg.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxNeg.Location = new System.Drawing.Point(130, 5);
            this.cbxNeg.Name = "cbxNeg";
            this.cbxNeg.Size = new System.Drawing.Size(100, 27);
            this.cbxNeg.TabIndex = 1;
            this.cbxNeg.Text = "负限位";
            this.cbxNeg.UseVisualStyleBackColor = true;
            // 
            // cbxRun
            // 
            this.cbxRun.AutoCheck = false;
            this.cbxRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxRun.Location = new System.Drawing.Point(8, 5);
            this.cbxRun.Name = "cbxRun";
            this.cbxRun.Size = new System.Drawing.Size(122, 27);
            this.cbxRun.TabIndex = 0;
            this.cbxRun.Text = "运行状态";
            this.cbxRun.UseVisualStyleBackColor = true;
            // 
            // lbTitlePreview
            // 
            this.lbTitlePreview.BackColor = System.Drawing.Color.LightGray;
            this.lbTitlePreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitlePreview.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitlePreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitlePreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitlePreview.Location = new System.Drawing.Point(0, 37);
            this.lbTitlePreview.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitlePreview.Name = "lbTitlePreview";
            this.lbTitlePreview.Size = new System.Drawing.Size(432, 27);
            this.lbTitlePreview.TabIndex = 24;
            this.lbTitlePreview.Text = "----------当前状态预览----------";
            this.lbTitlePreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.Silver;
            this.pnlSave.Controls.Add(this.pbxSaveAll);
            this.pnlSave.Controls.Add(this.lbSaveAll);
            this.pnlSave.Controls.Add(this.btnNext);
            this.pnlSave.Controls.Add(this.lbSplit);
            this.pnlSave.Controls.Add(this.btnPre);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSave.Location = new System.Drawing.Point(0, 413);
            this.pnlSave.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSave.Size = new System.Drawing.Size(432, 46);
            this.pnlSave.TabIndex = 23;
            // 
            // pbxSaveAll
            // 
            this.pbxSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSaveAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxSaveAll.Image = global::MTDevice.Properties.Resources.Apply;
            this.pbxSaveAll.Location = new System.Drawing.Point(315, 5);
            this.pbxSaveAll.Name = "pbxSaveAll";
            this.pbxSaveAll.Size = new System.Drawing.Size(27, 36);
            this.pbxSaveAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSaveAll.TabIndex = 33;
            this.pbxSaveAll.TabStop = false;
            this.pbxSaveAll.Click += new System.EventHandler(this.pbxSaveAll_Click);
            // 
            // lbSaveAll
            // 
            this.lbSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSaveAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSaveAll.Font = new System.Drawing.Font("宋体", 14F);
            this.lbSaveAll.ForeColor = System.Drawing.Color.Black;
            this.lbSaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSaveAll.Location = new System.Drawing.Point(342, 5);
            this.lbSaveAll.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSaveAll.Name = "lbSaveAll";
            this.lbSaveAll.Size = new System.Drawing.Size(85, 36);
            this.lbSaveAll.TabIndex = 32;
            this.lbSaveAll.Text = "全部应用";
            this.lbSaveAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSaveAll.Click += new System.EventHandler(this.pbxSaveAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNext.Location = new System.Drawing.Point(154, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(127, 36);
            this.btnNext.TabIndex = 31;
            this.btnNext.Tag = "+";
            this.btnNext.Text = "下一轴 >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.AxisSelect_Click);
            // 
            // lbSplit
            // 
            this.lbSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplit.Font = new System.Drawing.Font("宋体", 14F);
            this.lbSplit.ForeColor = System.Drawing.Color.Black;
            this.lbSplit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSplit.Location = new System.Drawing.Point(144, 5);
            this.lbSplit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSplit.Name = "lbSplit";
            this.lbSplit.Size = new System.Drawing.Size(10, 36);
            this.lbSplit.TabIndex = 30;
            this.lbSplit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPre
            // 
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPre.Location = new System.Drawing.Point(5, 5);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(139, 36);
            this.btnPre.TabIndex = 28;
            this.btnPre.Tag = "-";
            this.btnPre.Text = "<< 上一轴";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.AxisSelect_Click);
            // 
            // pnlSelectAxis
            // 
            this.pnlSelectAxis.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSelectAxis.Controls.Add(this.cbxSelectAxis);
            this.pnlSelectAxis.Controls.Add(this.lbSelectAxis);
            this.pnlSelectAxis.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectAxis.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectAxis.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSelectAxis.Name = "pnlSelectAxis";
            this.pnlSelectAxis.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.pnlSelectAxis.Size = new System.Drawing.Size(432, 37);
            this.pnlSelectAxis.TabIndex = 9;
            // 
            // cbxSelectAxis
            // 
            this.cbxSelectAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSelectAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectAxis.FormattingEnabled = true;
            this.cbxSelectAxis.Location = new System.Drawing.Point(130, 5);
            this.cbxSelectAxis.Name = "cbxSelectAxis";
            this.cbxSelectAxis.Size = new System.Drawing.Size(294, 27);
            this.cbxSelectAxis.TabIndex = 7;
            this.cbxSelectAxis.SelectedIndexChanged += new System.EventHandler(this.cbxSelectAxis_SelectedIndexChanged);
            // 
            // lbSelectAxis
            // 
            this.lbSelectAxis.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSelectAxis.Font = new System.Drawing.Font("宋体", 14F);
            this.lbSelectAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSelectAxis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSelectAxis.Location = new System.Drawing.Point(8, 5);
            this.lbSelectAxis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSelectAxis.Name = "lbSelectAxis";
            this.lbSelectAxis.Size = new System.Drawing.Size(122, 27);
            this.lbSelectAxis.TabIndex = 6;
            this.lbSelectAxis.Text = "选择轴对象:";
            this.lbSelectAxis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tmr_Data
            // 
            this.Tmr_Data.Enabled = true;
            this.Tmr_Data.Interval = 50;
            this.Tmr_Data.Tick += new System.EventHandler(this.Tmr_Data_Tick);
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 471);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 510);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 510);
            this.Name = "WindowsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJU - 设备状态测试";
            this.TopMost = true;
            this.pnlMain.ResumeLayout(false);
            this.pnlCalibrate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInit)).EndInit();
            this.pnlZero.ResumeLayout(false);
            this.pnlMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMove)).EndInit();
            this.pnlAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDecc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcc)).EndInit();
            this.pnlCaption.ResumeLayout(false);
            this.pnlCaption.PerformLayout();
            this.pnlValue.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSaveAll)).EndInit();
            this.pnlSelectAxis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCalibrate;
        private System.Windows.Forms.Button btnInitVerifi;
        private System.Windows.Forms.Label lbInit;
        private System.Windows.Forms.NumericUpDown nudInit;
        private System.Windows.Forms.PictureBox pbxInit;
        private System.Windows.Forms.Label lbTitleCalibrate;
        private System.Windows.Forms.Panel pnlZero;
        private System.Windows.Forms.Button btnHalt;
        private System.Windows.Forms.Label lbZeroSplit;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label lbMoveSplit;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.NumericUpDown nudMove;
        private System.Windows.Forms.Label lbMove;
        private System.Windows.Forms.Label lbTitleTest;
        private System.Windows.Forms.Panel pnlAcc;
        private System.Windows.Forms.NumericUpDown nudDecc;
        private System.Windows.Forms.Label lbDecc;
        private System.Windows.Forms.NumericUpDown nudAcc;
        private System.Windows.Forms.Label lbAcc;
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.TextBox tbxCaption;
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.Label lbTitleConfig;
        private System.Windows.Forms.Panel pnlValue;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.Label lbV;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.CheckBox cbxPos;
        private System.Windows.Forms.CheckBox cbxZero;
        private System.Windows.Forms.CheckBox cbxNeg;
        private System.Windows.Forms.CheckBox cbxRun;
        private System.Windows.Forms.Label lbTitlePreview;
        private System.Windows.Forms.Panel pnlSave;
        private System.Windows.Forms.Panel pnlSelectAxis;
        private System.Windows.Forms.ComboBox cbxSelectAxis;
        private System.Windows.Forms.Label lbSelectAxis;
        private System.Windows.Forms.CheckBox cbxPosZero;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbSplit;
        private System.Windows.Forms.Label lbSaveAll;
        private System.Windows.Forms.PictureBox pbxSaveAll;
        private System.Windows.Forms.Timer Tmr_Data;
    }
}

