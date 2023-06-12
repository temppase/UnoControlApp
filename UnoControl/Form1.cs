namespace UnoControl
{
    public partial class Form1 : Form
    {
        DataClass d = new DataClass();
        RequestClass r = new RequestClass();
        public Form1()
        {
            InitializeComponent();
            // Test input
            IntervalTb.Text = "15";
            MmTb.Text = "14";
            MinTb.Text = "1";
            STb.Text = "2";
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
                ResTb.Text = r.TcpSend(SetValues());
                PPBtn.Enabled = true;
            }

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            r.TcpSend("reset*");
            Thread.Sleep(1000);
            r.TcpSend("*");
        }

        private void StartLeft_CheckedChanged(object sender, EventArgs e)
        {
            SetDirection(true);
            r.TcpSend("max*");
            Thread.Sleep(1000);
            r.TcpSend("*");
        }

        private void StartRight_CheckedChanged(object sender, EventArgs e)
        {
            SetDirection(false);
            r.TcpSend("min*");
            Thread.Sleep(1000);
            r.TcpSend("*");
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
            PPBtn.Enabled = true;

        }
        private string SetValues()
        {
            if (MinTb.Text.Length == 0) { MinTb.Text = "0"; }
            if (STb.Text.Length == 0) { STb.Text = "0"; }
            if (IntervalTb.Text.Length == 0) { IntervalTb.Text = "0"; }
            d.Interval_count = Convert.ToInt32(IntervalTb.Text);
            d.Interval_time = Convert.ToInt32(MinTb.Text) * 60;
            d.Interval_time += Convert.ToInt32(STb.Text);
            d.Interval_length = Convert.ToInt32(MmTb.Text);
            return $"{d.Interval_count}|{d.Interval_length}|{d.Interval_time}|{d.Direction}|{d.Offset}*";
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
            ResTb.Text = r.TcpSend("play*");
            PPBtn.Text = "pause";
            PPBtn.BackColor = Color.DarkCyan;
            d.Play = true;
            StopBtn.Enabled = false;
            Thread.Sleep(1000);
            r.TcpSend("*");
        }
        private void Pause()
        {
            ResTb.Text = r.TcpSend("pause*");
            PPBtn.Text = "play";
            PPBtn.BackColor = Color.Cyan;
            d.Play = false;
            StopBtn.Enabled = true;
            Thread.Sleep(1000);
            r.TcpSend("*");
        }
        public string DataToString()
        {
            return $"Intervals: {d.Interval_count}\n" +
                $"Lenght: {d.Interval_length} mm\n" +
                $"Time: {d.Interval_time} s\n" +
                $"Start: {d.Offset}\n" +
                $"Direction: {d.Direction}";
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            ResTb.Text = r.TcpSend("*");
        }
    }
}