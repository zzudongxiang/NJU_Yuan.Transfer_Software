namespace Library
{
    partial class ExceptionBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionBox));
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbxTrack = new System.Windows.Forms.TextBox();
            this.lbTrackTitle = new System.Windows.Forms.Label();
            this.tbxEx = new System.Windows.Forms.TextBox();
            this.lbExTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMessage.Location = new System.Drawing.Point(5, 280);
            this.lbMessage.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbMessage.Size = new System.Drawing.Size(324, 26);
            this.lbMessage.TabIndex = 37;
            this.lbMessage.Text = "将该信息发送给开发者以助于修复该问题";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTrack
            // 
            this.tbxTrack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxTrack.Font = new System.Drawing.Font("宋体", 9F);
            this.tbxTrack.Location = new System.Drawing.Point(5, 111);
            this.tbxTrack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxTrack.Multiline = true;
            this.tbxTrack.Name = "tbxTrack";
            this.tbxTrack.ReadOnly = true;
            this.tbxTrack.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxTrack.Size = new System.Drawing.Size(324, 169);
            this.tbxTrack.TabIndex = 36;
            this.tbxTrack.TabStop = false;
            // 
            // lbTrackTitle
            // 
            this.lbTrackTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTrackTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTrackTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTrackTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTrackTitle.Location = new System.Drawing.Point(5, 77);
            this.lbTrackTitle.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbTrackTitle.Name = "lbTrackTitle";
            this.lbTrackTitle.Size = new System.Drawing.Size(324, 34);
            this.lbTrackTitle.TabIndex = 35;
            this.lbTrackTitle.Text = "----------异常堆栈信息----------";
            this.lbTrackTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEx
            // 
            this.tbxEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEx.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxEx.Location = new System.Drawing.Point(5, 34);
            this.tbxEx.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxEx.Multiline = true;
            this.tbxEx.Name = "tbxEx";
            this.tbxEx.ReadOnly = true;
            this.tbxEx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxEx.Size = new System.Drawing.Size(324, 43);
            this.tbxEx.TabIndex = 34;
            this.tbxEx.TabStop = false;
            this.tbxEx.Text = "异常信息摘要";
            // 
            // lbExTitle
            // 
            this.lbExTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbExTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbExTitle.ForeColor = System.Drawing.Color.Red;
            this.lbExTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbExTitle.Location = new System.Drawing.Point(5, 0);
            this.lbExTitle.Margin = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.lbExTitle.Name = "lbExTitle";
            this.lbExTitle.Size = new System.Drawing.Size(324, 34);
            this.lbExTitle.TabIndex = 33;
            this.lbExTitle.Text = "----------异常信息摘要----------";
            this.lbExTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExceptionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbxTrack);
            this.Controls.Add(this.lbTrackTitle);
            this.Controls.Add(this.tbxEx);
            this.Controls.Add(this.lbExTitle);
            this.Font = new System.Drawing.Font("宋体", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "ExceptionBox";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJU - 运行时错误";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbxTrack;
        private System.Windows.Forms.Label lbTrackTitle;
        private System.Windows.Forms.TextBox tbxEx;
        private System.Windows.Forms.Label lbExTitle;
    }
}