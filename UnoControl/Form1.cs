namespace UnoControl
{
    public partial class Form1 : Form
    {
        DataClass d = new DataClass();
        RequestClass r = new RequestClass();
        public Form1()
        {
            InitializeComponent();
            StartRight.Select();
            SledgeBar.Value = SledgeBar.Minimum;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(MmTb.Text.Length == 0) { ResTb.Text = "Set interval length first (mm)!"; }
            else
            {
                SetValues();
                ResTb.Text = r.SendData(d.Interval_length,
                                        d.Interval_time, 
                                        d.Interval_count,
                                        Convert.ToInt32(d.Direction), 
                                        d.Offset).Result;
            }

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            ResTb.Text = r.SendData(0, 0, 0, 0, 0).Result;
        }

        private void StartLeft_CheckedChanged(object sender, EventArgs e)
        {
            SetDirection(true);
        }

        private void StartRight_CheckedChanged(object sender, EventArgs e)
        {
            SetDirection(false);
        }

        private void SetDirection(bool left)
        {
            if(left)
            {
                d.Direction = 1;
                d.Offset = SledgeBar.Maximum;
                SledgeBar.Value = SledgeBar.Maximum;
                ResTb.Text = $"Left start, state:{StartLeft.TabStop}";
            }
            else
            {
                d.Direction = -1;
                d.Offset = SledgeBar.Minimum;
                SledgeBar.Value = SledgeBar.Minimum;
                ResTb.Text = $"Right start, state:{StartRight.TabStop}";
            }
        }

        private void SledgeBar_Scroll(object sender, EventArgs e)
        {
            d.Offset = SledgeBar.Value;
        }
        private void SetValues()
        {
            if(MinTb.Text.Length == 0) { MinTb.Text = "0"; }
            if(STb.Text.Length == 0) { STb.Text = "0"; }
            d.Interval_count = Convert.ToInt32(IntervalTb.Text);
            d.Interval_time = Convert.ToInt32(MinTb.Text) * 60;
            d.Interval_time += Convert.ToInt32(STb.Text);
            d.Interval_length = Convert.ToInt32(MmTb.Text);
        }
    }
}