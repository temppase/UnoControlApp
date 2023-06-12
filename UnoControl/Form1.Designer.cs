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
            label1 = new Label();
            MinTb = new TextBox();
            SendBtn = new Button();
            StartRight = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            StartLeft = new RadioButton();
            SledgeBar = new TrackBar();
            IntervalTb = new TextBox();
            STb = new TextBox();
            label5 = new Label();
            ResTb = new RichTextBox();
            StopBtn = new Button();
            label6 = new Label();
            MmTb = new TextBox();
            label7 = new Label();
            DirLb = new Label();
            PPBtn = new Button();
            InfoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SledgeBar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 180);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 0;
            label1.Text = ":";
            // 
            // MinTb
            // 
            MinTb.Location = new Point(61, 177);
            MinTb.Margin = new Padding(1, 1, 1, 1);
            MinTb.Name = "MinTb";
            MinTb.Size = new Size(35, 27);
            MinTb.TabIndex = 1;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.FromArgb(128, 255, 128);
            SendBtn.FlatStyle = FlatStyle.Flat;
            SendBtn.Location = new Point(191, 96);
            SendBtn.Margin = new Padding(1, 1, 1, 1);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(66, 36);
            SendBtn.TabIndex = 3;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // StartRight
            // 
            StartRight.AutoSize = true;
            StartRight.Location = new Point(678, 353);
            StartRight.Margin = new Padding(1, 1, 1, 1);
            StartRight.Name = "StartRight";
            StartRight.Size = new Size(61, 24);
            StartRight.TabIndex = 4;
            StartRight.TabStop = true;
            StartRight.Text = "Start";
            StartRight.UseVisualStyleBackColor = true;
            StartRight.CheckedChanged += StartRight_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(56, 55);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 0;
            label2.Text = "Set values";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 155);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 0;
            label3.Text = "min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 96);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 0;
            label4.Text = "Intervals";
            // 
            // StartLeft
            // 
            StartLeft.AutoSize = true;
            StartLeft.Location = new Point(43, 353);
            StartLeft.Margin = new Padding(1, 1, 1, 1);
            StartLeft.Name = "StartLeft";
            StartLeft.RightToLeft = RightToLeft.Yes;
            StartLeft.Size = new Size(61, 24);
            StartLeft.TabIndex = 4;
            StartLeft.TabStop = true;
            StartLeft.Text = "Start";
            StartLeft.UseVisualStyleBackColor = true;
            StartLeft.CheckedChanged += StartLeft_CheckedChanged;
            // 
            // SledgeBar
            // 
            SledgeBar.BackColor = Color.FromArgb(255, 192, 128);
            SledgeBar.Location = new Point(106, 337);
            SledgeBar.Margin = new Padding(1, 1, 1, 1);
            SledgeBar.Name = "SledgeBar";
            SledgeBar.RightToLeft = RightToLeft.Yes;
            SledgeBar.RightToLeftLayout = true;
            SledgeBar.Size = new Size(561, 56);
            SledgeBar.TabIndex = 5;
            SledgeBar.TickStyle = TickStyle.TopLeft;
            SledgeBar.Scroll += SledgeBar_Scroll;
            // 
            // IntervalTb
            // 
            IntervalTb.Location = new Point(61, 118);
            IntervalTb.Margin = new Padding(1, 1, 1, 1);
            IntervalTb.Name = "IntervalTb";
            IntervalTb.Size = new Size(38, 27);
            IntervalTb.TabIndex = 1;
            // 
            // STb
            // 
            STb.Location = new Point(106, 178);
            STb.Margin = new Padding(1, 1, 1, 1);
            STb.Name = "STb";
            STb.Size = new Size(35, 27);
            STb.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 155);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 0;
            label5.Text = "s";
            // 
            // ResTb
            // 
            ResTb.Location = new Point(434, 33);
            ResTb.Margin = new Padding(1, 1, 1, 1);
            ResTb.Name = "ResTb";
            ResTb.Size = new Size(287, 253);
            ResTb.TabIndex = 6;
            ResTb.Text = "Response...";
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.FromArgb(255, 128, 128);
            StopBtn.FlatStyle = FlatStyle.Flat;
            StopBtn.Location = new Point(191, 187);
            StopBtn.Margin = new Padding(1, 1, 1, 1);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(66, 36);
            StopBtn.TabIndex = 3;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 264);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(271, 20);
            label6.TabIndex = 7;
            label6.Text = "Drag bar to set offset or set start corner\r\n";
            // 
            // MmTb
            // 
            MmTb.Location = new Point(60, 230);
            MmTb.Margin = new Padding(1, 1, 1, 1);
            MmTb.Name = "MmTb";
            MmTb.Size = new Size(81, 27);
            MmTb.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 202);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 9;
            label7.Text = "mm";
            // 
            // DirLb
            // 
            DirLb.AutoSize = true;
            DirLb.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            DirLb.Location = new Point(355, 300);
            DirLb.Margin = new Padding(1, 0, 1, 0);
            DirLb.Name = "DirLb";
            DirLb.Size = new Size(51, 32);
            DirLb.TabIndex = 10;
            DirLb.Text = "<--";
            // 
            // PPBtn
            // 
            PPBtn.BackColor = Color.FromArgb(0, 192, 192);
            PPBtn.FlatStyle = FlatStyle.Flat;
            PPBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PPBtn.Location = new Point(191, 140);
            PPBtn.Margin = new Padding(1, 1, 1, 1);
            PPBtn.Name = "PPBtn";
            PPBtn.Size = new Size(66, 36);
            PPBtn.TabIndex = 3;
            PPBtn.Text = ">";
            PPBtn.UseVisualStyleBackColor = false;
            PPBtn.Click += PPBtn_Click;
            // 
            // InfoBtn
            // 
            InfoBtn.BackColor = Color.FromArgb(255, 255, 192);
            InfoBtn.FlatStyle = FlatStyle.Flat;
            InfoBtn.Location = new Point(340, 33);
            InfoBtn.Margin = new Padding(1);
            InfoBtn.Name = "InfoBtn";
            InfoBtn.Size = new Size(66, 36);
            InfoBtn.TabIndex = 3;
            InfoBtn.Text = "Info";
            InfoBtn.UseVisualStyleBackColor = false;
            InfoBtn.Click += InfoBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(759, 414);
            Controls.Add(DirLb);
            Controls.Add(label7);
            Controls.Add(MmTb);
            Controls.Add(label6);
            Controls.Add(ResTb);
            Controls.Add(SledgeBar);
            Controls.Add(StartLeft);
            Controls.Add(StartRight);
            Controls.Add(PPBtn);
            Controls.Add(StopBtn);
            Controls.Add(InfoBtn);
            Controls.Add(SendBtn);
            Controls.Add(IntervalTb);
            Controls.Add(STb);
            Controls.Add(MinTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Form1";
            Text = "Uno Controller";
            ((System.ComponentModel.ISupportInitialize)SledgeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label DirLb;
        private Button PPBtn;
        private Button InfoBtn;
    }
}