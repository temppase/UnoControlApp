namespace UnoControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MinTb = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.StartRight = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartLeft = new System.Windows.Forms.RadioButton();
            this.SledgeBar = new System.Windows.Forms.TrackBar();
            this.IntervalTb = new System.Windows.Forms.TextBox();
            this.STb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResTb = new System.Windows.Forms.RichTextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MmTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SledgeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            // 
            // MinTb
            // 
            this.MinTb.Location = new System.Drawing.Point(130, 362);
            this.MinTb.Name = "MinTb";
            this.MinTb.Size = new System.Drawing.Size(69, 47);
            this.MinTb.TabIndex = 1;
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SendBtn.Location = new System.Drawing.Point(405, 197);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(140, 73);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // StartRight
            // 
            this.StartRight.AutoSize = true;
            this.StartRight.Location = new System.Drawing.Point(1441, 724);
            this.StartRight.Name = "StartRight";
            this.StartRight.Size = new System.Drawing.Size(115, 45);
            this.StartRight.TabIndex = 4;
            this.StartRight.TabStop = true;
            this.StartRight.Text = "Start";
            this.StartRight.UseVisualStyleBackColor = true;
            this.StartRight.CheckedChanged += new System.EventHandler(this.StartRight_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Set values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Intervals";
            // 
            // StartLeft
            // 
            this.StartLeft.AutoSize = true;
            this.StartLeft.Location = new System.Drawing.Point(91, 724);
            this.StartLeft.Name = "StartLeft";
            this.StartLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartLeft.Size = new System.Drawing.Size(115, 45);
            this.StartLeft.TabIndex = 4;
            this.StartLeft.TabStop = true;
            this.StartLeft.Text = "Start";
            this.StartLeft.UseVisualStyleBackColor = true;
            this.StartLeft.CheckedChanged += new System.EventHandler(this.StartLeft_CheckedChanged);
            // 
            // SledgeBar
            // 
            this.SledgeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SledgeBar.Location = new System.Drawing.Point(226, 691);
            this.SledgeBar.Name = "SledgeBar";
            this.SledgeBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SledgeBar.RightToLeftLayout = true;
            this.SledgeBar.Size = new System.Drawing.Size(1192, 114);
            this.SledgeBar.TabIndex = 5;
            this.SledgeBar.Scroll += new System.EventHandler(this.SledgeBar_Scroll);
            // 
            // IntervalTb
            // 
            this.IntervalTb.Location = new System.Drawing.Point(130, 241);
            this.IntervalTb.Name = "IntervalTb";
            this.IntervalTb.Size = new System.Drawing.Size(76, 47);
            this.IntervalTb.TabIndex = 1;
            // 
            // STb
            // 
            this.STb.Location = new System.Drawing.Point(226, 365);
            this.STb.Name = "STb";
            this.STb.Size = new System.Drawing.Size(69, 47);
            this.STb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "s";
            // 
            // ResTb
            // 
            this.ResTb.Location = new System.Drawing.Point(922, 68);
            this.ResTb.Name = "ResTb";
            this.ResTb.Size = new System.Drawing.Size(606, 514);
            this.ResTb.TabIndex = 6;
            this.ResTb.Text = "Response...";
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StopBtn.Location = new System.Drawing.Point(405, 286);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(140, 73);
            this.StopBtn.TabIndex = 3;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(541, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "Drag bar to set offset or set start corner\r\n";
            // 
            // MmTb
            // 
            this.MmTb.Location = new System.Drawing.Point(128, 471);
            this.MmTb.Name = "MmTb";
            this.MmTb.Size = new System.Drawing.Size(167, 47);
            this.MmTb.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 41);
            this.label7.TabIndex = 9;
            this.label7.Text = "mm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1612, 849);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MmTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResTb);
            this.Controls.Add(this.SledgeBar);
            this.Controls.Add(this.StartLeft);
            this.Controls.Add(this.StartRight);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.IntervalTb);
            this.Controls.Add(this.STb);
            this.Controls.Add(this.MinTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Uno Controller";
            ((System.ComponentModel.ISupportInitialize)(this.SledgeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox MinTb;
        private Button SendBtn;
        private RadioButton StartRight;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton StartLeft;
        private TrackBar SledgeBar;
        private TextBox IntervalTb;
        private TextBox STb;
        private Label label5;
        private RichTextBox ResTb;
        private Button StopBtn;
        private Label label6;
        private TextBox MmTb;
        private Label label7;
    }
}