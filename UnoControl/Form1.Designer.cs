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
            ((System.ComponentModel.ISupportInitialize)SledgeBar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 368);
            label1.Name = "label1";
            label1.Size = new Size(25, 41);
            label1.TabIndex = 0;
            label1.Text = ":";
            // 
            // MinTb
            // 
            MinTb.Location = new Point(130, 362);
            MinTb.Name = "MinTb";
            MinTb.Size = new Size(69, 47);
            MinTb.TabIndex = 1;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.FromArgb(128, 255, 128);
            SendBtn.FlatStyle = FlatStyle.Flat;
            SendBtn.Location = new Point(405, 197);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(140, 73);
            SendBtn.TabIndex = 3;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += SendBtn_Click;
            // 
            // StartRight
            // 
            StartRight.AutoSize = true;
            StartRight.Location = new Point(1441, 724);
            StartRight.Name = "StartRight";
            StartRight.Size = new Size(115, 45);
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
            label2.Location = new Point(119, 113);
            label2.Name = "label2";
            label2.Size = new Size(245, 62);
            label2.TabIndex = 0;
            label2.Text = "Set values";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 318);
            label3.Name = "label3";
            label3.Size = new Size(68, 41);
            label3.TabIndex = 0;
            label3.Text = "min";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 197);
            label4.Name = "label4";
            label4.Size = new Size(128, 41);
            label4.TabIndex = 0;
            label4.Text = "Intervals";
            // 
            // StartLeft
            // 
            StartLeft.AutoSize = true;
            StartLeft.Location = new Point(91, 724);
            StartLeft.Name = "StartLeft";
            StartLeft.RightToLeft = RightToLeft.Yes;
            StartLeft.Size = new Size(115, 45);
            StartLeft.TabIndex = 4;
            StartLeft.TabStop = true;
            StartLeft.Text = "Start";
            StartLeft.UseVisualStyleBackColor = true;
            StartLeft.CheckedChanged += StartLeft_CheckedChanged;
            // 
            // SledgeBar
            // 
            SledgeBar.BackColor = Color.FromArgb(255, 192, 128);
            SledgeBar.Location = new Point(226, 691);
            SledgeBar.Name = "SledgeBar";
            SledgeBar.RightToLeft = RightToLeft.Yes;
            SledgeBar.RightToLeftLayout = true;
            SledgeBar.Size = new Size(1192, 114);
            SledgeBar.TabIndex = 5;
            SledgeBar.TickStyle = TickStyle.TopLeft;
            SledgeBar.Scroll += SledgeBar_Scroll;
            // 
            // IntervalTb
            // 
            IntervalTb.Location = new Point(130, 241);
            IntervalTb.Name = "IntervalTb";
            IntervalTb.Size = new Size(76, 47);
            IntervalTb.TabIndex = 1;
            // 
            // STb
            // 
            STb.Location = new Point(226, 365);
            STb.Name = "STb";
            STb.Size = new Size(69, 47);
            STb.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 318);
            label5.Name = "label5";
            label5.Size = new Size(31, 41);
            label5.TabIndex = 0;
            label5.Text = "s";
            // 
            // ResTb
            // 
            ResTb.Location = new Point(922, 68);
            ResTb.Name = "ResTb";
            ResTb.Size = new Size(606, 514);
            ResTb.TabIndex = 6;
            ResTb.Text = "Response...";
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.FromArgb(255, 128, 128);
            StopBtn.FlatStyle = FlatStyle.Flat;
            StopBtn.Location = new Point(405, 383);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(140, 73);
            StopBtn.TabIndex = 3;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 541);
            label6.Name = "label6";
            label6.Size = new Size(541, 41);
            label6.TabIndex = 7;
            label6.Text = "Drag bar to set offset or set start corner\r\n";
            // 
            // MmTb
            // 
            MmTb.Location = new Point(128, 471);
            MmTb.Name = "MmTb";
            MmTb.Size = new Size(167, 47);
            MmTb.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 415);
            label7.Name = "label7";
            label7.Size = new Size(70, 41);
            label7.TabIndex = 9;
            label7.Text = "mm";
            // 
            // DirLb
            // 
            DirLb.AutoSize = true;
            DirLb.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            DirLb.Location = new Point(755, 614);
            DirLb.Name = "DirLb";
            DirLb.Size = new Size(98, 62);
            DirLb.TabIndex = 10;
            DirLb.Text = "<--";
            // 
            // PPBtn
            // 
            PPBtn.BackColor = Color.FromArgb(0, 192, 192);
            PPBtn.FlatStyle = FlatStyle.Flat;
            PPBtn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PPBtn.Location = new Point(405, 286);
            PPBtn.Name = "PPBtn";
            PPBtn.Size = new Size(140, 73);
            PPBtn.TabIndex = 3;
            PPBtn.Text = ">";
            PPBtn.UseVisualStyleBackColor = false;
            PPBtn.Click += PPBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1612, 849);
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
            Controls.Add(SendBtn);
            Controls.Add(IntervalTb);
            Controls.Add(STb);
            Controls.Add(MinTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
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
    }
}