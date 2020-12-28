namespace CSharpDemo
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Check = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Acc = new System.Windows.Forms.TextBox();
            this.btn_Acc = new System.Windows.Forms.Button();
            this.txt_Dec = new System.Windows.Forms.TextBox();
            this.btn_Dec = new System.Windows.Forms.Button();
            this.txt_MaxV = new System.Windows.Forms.TextBox();
            this.btn_MaxV = new System.Windows.Forms.Button();
            this.txt_Ref = new System.Windows.Forms.TextBox();
            this.btn_Ref = new System.Windows.Forms.Button();
            this.txt_Abs = new System.Windows.Forms.TextBox();
            this.btn_Abs = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Halt = new System.Windows.Forms.Button();
            this.btn_Pos = new System.Windows.Forms.Button();
            this.txt_Pos = new System.Windows.Forms.TextBox();
            this.chk_Run = new System.Windows.Forms.CheckBox();
            this.chk_Dir = new System.Windows.Forms.CheckBox();
            this.chk_Neg = new System.Windows.Forms.CheckBox();
            this.chk_Pos = new System.Windows.Forms.CheckBox();
            this.chk_Zero = new System.Windows.Forms.CheckBox();
            this.btn_Status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(150, 19);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(93, 29);
            this.btn_Check.TabIndex = 0;
            this.btn_Check.Text = "检测板卡";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(23, 24);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(100, 21);
            this.txt_Port.TabIndex = 1;
            this.txt_Port.Text = "COM1";
            // 
            // txt_Acc
            // 
            this.txt_Acc.Location = new System.Drawing.Point(23, 75);
            this.txt_Acc.Name = "txt_Acc";
            this.txt_Acc.Size = new System.Drawing.Size(100, 21);
            this.txt_Acc.TabIndex = 3;
            this.txt_Acc.Text = "500";
            // 
            // btn_Acc
            // 
            this.btn_Acc.Location = new System.Drawing.Point(150, 70);
            this.btn_Acc.Name = "btn_Acc";
            this.btn_Acc.Size = new System.Drawing.Size(93, 29);
            this.btn_Acc.TabIndex = 2;
            this.btn_Acc.Text = "加速度";
            this.btn_Acc.UseVisualStyleBackColor = true;
            this.btn_Acc.Click += new System.EventHandler(this.btn_Acc_Click);
            // 
            // txt_Dec
            // 
            this.txt_Dec.Location = new System.Drawing.Point(283, 75);
            this.txt_Dec.Name = "txt_Dec";
            this.txt_Dec.Size = new System.Drawing.Size(100, 21);
            this.txt_Dec.TabIndex = 5;
            this.txt_Dec.Text = "500";
            // 
            // btn_Dec
            // 
            this.btn_Dec.Location = new System.Drawing.Point(410, 70);
            this.btn_Dec.Name = "btn_Dec";
            this.btn_Dec.Size = new System.Drawing.Size(93, 29);
            this.btn_Dec.TabIndex = 4;
            this.btn_Dec.Text = "减速度";
            this.btn_Dec.UseVisualStyleBackColor = true;
            this.btn_Dec.Click += new System.EventHandler(this.btn_Dec_Click);
            // 
            // txt_MaxV
            // 
            this.txt_MaxV.Location = new System.Drawing.Point(23, 122);
            this.txt_MaxV.Name = "txt_MaxV";
            this.txt_MaxV.Size = new System.Drawing.Size(100, 21);
            this.txt_MaxV.TabIndex = 7;
            this.txt_MaxV.Text = "5000";
            // 
            // btn_MaxV
            // 
            this.btn_MaxV.Location = new System.Drawing.Point(150, 117);
            this.btn_MaxV.Name = "btn_MaxV";
            this.btn_MaxV.Size = new System.Drawing.Size(146, 29);
            this.btn_MaxV.TabIndex = 6;
            this.btn_MaxV.Text = "位置模式最大速度";
            this.btn_MaxV.UseVisualStyleBackColor = true;
            this.btn_MaxV.Click += new System.EventHandler(this.btn_MaxV_Click);
            // 
            // txt_Ref
            // 
            this.txt_Ref.Location = new System.Drawing.Point(23, 175);
            this.txt_Ref.Name = "txt_Ref";
            this.txt_Ref.Size = new System.Drawing.Size(100, 21);
            this.txt_Ref.TabIndex = 9;
            this.txt_Ref.Text = "10000";
            // 
            // btn_Ref
            // 
            this.btn_Ref.Location = new System.Drawing.Point(150, 170);
            this.btn_Ref.Name = "btn_Ref";
            this.btn_Ref.Size = new System.Drawing.Size(93, 29);
            this.btn_Ref.TabIndex = 8;
            this.btn_Ref.Text = "相对移动";
            this.btn_Ref.UseVisualStyleBackColor = true;
            this.btn_Ref.Click += new System.EventHandler(this.btn_Ref_Click);
            // 
            // txt_Abs
            // 
            this.txt_Abs.Location = new System.Drawing.Point(23, 219);
            this.txt_Abs.Name = "txt_Abs";
            this.txt_Abs.Size = new System.Drawing.Size(100, 21);
            this.txt_Abs.TabIndex = 11;
            this.txt_Abs.Text = "10000";
            // 
            // btn_Abs
            // 
            this.btn_Abs.Location = new System.Drawing.Point(150, 214);
            this.btn_Abs.Name = "btn_Abs";
            this.btn_Abs.Size = new System.Drawing.Size(93, 29);
            this.btn_Abs.TabIndex = 10;
            this.btn_Abs.Text = "绝对移动";
            this.btn_Abs.UseVisualStyleBackColor = true;
            this.btn_Abs.Click += new System.EventHandler(this.btn_Abs_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(76, 262);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(86, 29);
            this.btn_Stop.TabIndex = 12;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Halt
            // 
            this.btn_Halt.Location = new System.Drawing.Point(76, 297);
            this.btn_Halt.Name = "btn_Halt";
            this.btn_Halt.Size = new System.Drawing.Size(86, 29);
            this.btn_Halt.TabIndex = 13;
            this.btn_Halt.Text = "急停";
            this.btn_Halt.UseVisualStyleBackColor = true;
            this.btn_Halt.Click += new System.EventHandler(this.btn_Halt_Click);
            // 
            // btn_Pos
            // 
            this.btn_Pos.Location = new System.Drawing.Point(356, 202);
            this.btn_Pos.Name = "btn_Pos";
            this.btn_Pos.Size = new System.Drawing.Size(81, 38);
            this.btn_Pos.TabIndex = 14;
            this.btn_Pos.Text = "读当前位置";
            this.btn_Pos.UseVisualStyleBackColor = true;
            // 
            // txt_Pos
            // 
            this.txt_Pos.Location = new System.Drawing.Point(346, 170);
            this.txt_Pos.Name = "txt_Pos";
            this.txt_Pos.Size = new System.Drawing.Size(100, 21);
            this.txt_Pos.TabIndex = 15;
            // 
            // chk_Run
            // 
            this.chk_Run.AutoSize = true;
            this.chk_Run.Location = new System.Drawing.Point(618, 51);
            this.chk_Run.Name = "chk_Run";
            this.chk_Run.Size = new System.Drawing.Size(48, 16);
            this.chk_Run.TabIndex = 16;
            this.chk_Run.Text = "运行";
            this.chk_Run.UseVisualStyleBackColor = true;
            // 
            // chk_Dir
            // 
            this.chk_Dir.AutoSize = true;
            this.chk_Dir.Location = new System.Drawing.Point(618, 83);
            this.chk_Dir.Name = "chk_Dir";
            this.chk_Dir.Size = new System.Drawing.Size(48, 16);
            this.chk_Dir.TabIndex = 17;
            this.chk_Dir.Text = "方向";
            this.chk_Dir.UseVisualStyleBackColor = true;
            // 
            // chk_Neg
            // 
            this.chk_Neg.AutoSize = true;
            this.chk_Neg.Location = new System.Drawing.Point(618, 117);
            this.chk_Neg.Name = "chk_Neg";
            this.chk_Neg.Size = new System.Drawing.Size(60, 16);
            this.chk_Neg.TabIndex = 18;
            this.chk_Neg.Text = "负限位";
            this.chk_Neg.UseVisualStyleBackColor = true;
            // 
            // chk_Pos
            // 
            this.chk_Pos.AutoSize = true;
            this.chk_Pos.Location = new System.Drawing.Point(618, 152);
            this.chk_Pos.Name = "chk_Pos";
            this.chk_Pos.Size = new System.Drawing.Size(60, 16);
            this.chk_Pos.TabIndex = 19;
            this.chk_Pos.Text = "正限位";
            this.chk_Pos.UseVisualStyleBackColor = true;
            // 
            // chk_Zero
            // 
            this.chk_Zero.AutoSize = true;
            this.chk_Zero.Location = new System.Drawing.Point(618, 183);
            this.chk_Zero.Name = "chk_Zero";
            this.chk_Zero.Size = new System.Drawing.Size(48, 16);
            this.chk_Zero.TabIndex = 20;
            this.chk_Zero.Text = "零位";
            this.chk_Zero.UseVisualStyleBackColor = true;
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(615, 219);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(81, 38);
            this.btn_Status.TabIndex = 21;
            this.btn_Status.Text = "读状态";
            this.btn_Status.UseVisualStyleBackColor = true;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 363);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.chk_Zero);
            this.Controls.Add(this.chk_Pos);
            this.Controls.Add(this.chk_Neg);
            this.Controls.Add(this.chk_Dir);
            this.Controls.Add(this.chk_Run);
            this.Controls.Add(this.txt_Pos);
            this.Controls.Add(this.btn_Pos);
            this.Controls.Add(this.btn_Halt);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.txt_Abs);
            this.Controls.Add(this.btn_Abs);
            this.Controls.Add(this.txt_Ref);
            this.Controls.Add(this.btn_Ref);
            this.Controls.Add(this.txt_MaxV);
            this.Controls.Add(this.btn_MaxV);
            this.Controls.Add(this.txt_Dec);
            this.Controls.Add(this.btn_Dec);
            this.Controls.Add(this.txt_Acc);
            this.Controls.Add(this.btn_Acc);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.btn_Check);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Acc;
        private System.Windows.Forms.Button btn_Acc;
        private System.Windows.Forms.TextBox txt_Dec;
        private System.Windows.Forms.Button btn_Dec;
        private System.Windows.Forms.TextBox txt_MaxV;
        private System.Windows.Forms.Button btn_MaxV;
        private System.Windows.Forms.TextBox txt_Ref;
        private System.Windows.Forms.Button btn_Ref;
        private System.Windows.Forms.TextBox txt_Abs;
        private System.Windows.Forms.Button btn_Abs;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Halt;
        private System.Windows.Forms.Button btn_Pos;
        private System.Windows.Forms.TextBox txt_Pos;
        private System.Windows.Forms.CheckBox chk_Run;
        private System.Windows.Forms.CheckBox chk_Dir;
        private System.Windows.Forms.CheckBox chk_Neg;
        private System.Windows.Forms.CheckBox chk_Pos;
        private System.Windows.Forms.CheckBox chk_Zero;
        private System.Windows.Forms.Button btn_Status;
    }
}

