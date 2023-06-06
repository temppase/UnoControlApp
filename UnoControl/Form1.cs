namespace UnoControl
{
    public partial class Form1 : Form
    {
        DataClass d = new DataClass();
        RequestClass r = new RequestClass();
        public Form1()
        {
            InitializeComponent();
            SledgeBar.Maximum = 3600; // mm
            StartRight.Select();
            SledgeBar.Value = SledgeBar.Minimum;
            d.Play = false; // add check!!!
            d.Stop = false; // does it need check?
            PPBtn.BackColor = Color.Cyan;
            PPBtn.Enabled = false;
            StopBtn.Enabled = false;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (MmTb.Text.Length == 0) { ResTb.Text = "Set interval length first (mm)!"; }
            else
            {
                SetValues();
                ResTb.Text = r.SendData(d.Interval_length,
                                        d.Interval_time,
                                        d.Interval_count,
                                        Convert.ToInt32(d.Direction),
                                        d.Offset).Result;
                ResTb.Text = DataToString();
                PPBtn.Enabled = true;
            }

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (d.Stop) { Reset(); }
            else { Stop(); }
            //ResTb.Text = r.SendData(0, 0, 0, 0, 0).Result;
        }
        private void Reset()
        {
            // Reset condition
            ResTb.Text = "Reset and back to zero";
            d.Stop = false;
            StopBtn.Text = "Stop";
        }
        private void Stop()
        {
            // Stop condition
            ResTb.Text = "Stop process";
            d.Stop = true;
            StopBtn.Text = "Reset";
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
            if (left)
            {
                d.Direction = -1;
                d.Offset = SledgeBar.Maximum;
                SledgeBar.Value = SledgeBar.Maximum;
                ResTb.Text = $"Left start, state:{StartLeft.TabStop}";
                DirLb.Text = "-->";
            }
            else
            {
                d.Direction = 1;
                d.Offset = SledgeBar.Minimum;
                SledgeBar.Value = SledgeBar.Minimum;
                ResTb.Text = $"Right start, state:{StartRight.TabStop}";
                DirLb.Text = "<--";
            }
        }

        private void SledgeBar_Scroll(object sender, EventArgs e)
        {
            d.Offset = SledgeBar.Value;
            ResTb.Text = $"Offset: {SledgeBar.Value} mm";

        }
        private void SetValues()
        {
            if (MinTb.Text.Length == 0) { MinTb.Text = "0"; }
            if (STb.Text.Length == 0) { STb.Text = "0"; }
            d.Interval_count = Convert.ToInt32(IntervalTb.Text);
            d.Interval_time = Convert.ToInt32(MinTb.Text) * 60;
            d.Interval_time += Convert.ToInt32(STb.Text);
            d.Interval_length = Convert.ToInt32(MmTb.Text);
        }

        private void PPBtn_Click(object sender, EventArgs e)
        {
            StopBtn.Enabled = true;
            if (d.Play)
            {
                Pause();
            }
            else
            {
                Play();
            }
        }
        private void Play()
        {
            ResTb.Text = $"State: Play";
            PPBtn.Text = "||";
            PPBtn.BackColor = Color.DarkCyan;
            d.Play = true;
        }
        private void Pause()
        {
            ResTb.Text = $"State: Pause";
            PPBtn.Text = ">";
            PPBtn.BackColor = Color.Cyan;
            d.Play = false;
        }
        public string DataToString()
        {
            return $"Intervals: {d.Interval_count}\n" +
                $"Lenght: {d.Interval_length} mm\n" +
                $"Time: {d.Interval_time} s\n" +
                $"Start: {d.Offset}\n" +
                $"Direction: {d.Direction}";
        }

    }
}