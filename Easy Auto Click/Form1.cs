namespace Easy_Auto_Click
{
    public partial class easyAutoClick : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        int numHours = 0;
        int numMinutes = 0;
        int numSeconds = 0;
        int numMilliseconds = 0;
        int countdownTimer = 0;
        public easyAutoClick()
        {
            InitializeComponent();
        }

        private static void TimerEventProcessor(Object sender, EventArgs e)
        {
            myTimer.Stop();


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbHours.Text, out numHours))
            {
                // Hours successfully parsed
            }

            if (int.TryParse(tbMinutes.Text, out numMinutes))
            {
                // Minutes successfully parsed
            }

            if (int.TryParse(tbSeconds.Text, out numSeconds))
            {
                // Seconds successfully parsed
            }

            if ((int.TryParse(tbMilliseconds.Text, out numMilliseconds)))
            {
                // Milliseconds successfully parsed
            }

            if (numHours != 0 || numMinutes != 0 || numSeconds != 0 || numMilliseconds != 0)
            {
                countdownTimer = Time.TimeInputCalculation(numHours, numMinutes, numSeconds, numMilliseconds);

                // myTimer.Tick += new EventHandler(TimerEventProcessor);
                myTimer.Start();

                while (countdownTimer >= 0)
                {
                    Time.TimerClass(countdownTimer);
                    countdownTimer--;
                }



                myTimer.Stop();
            }




        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            int leftOverTime = countdownTimer;
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alwaysOnTopToolStripMenuItem.Checked)
            {
                this.TopMost = true;
            }
            else if (!alwaysOnTopToolStripMenuItem.Checked)
            { 
                this.TopMost = false; 
            }
        }
    }
}
