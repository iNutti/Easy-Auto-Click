using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace Easy_Auto_Click
{
    public partial class easyAutoClick : Form
    {
        public CancellationTokenSource cts = new();

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        string userDefinedKeys = "a";

        int numHours = 0;
        int numMinutes = 0;
        int numSeconds = 0;
        int numMilliseconds = 0;
        int countdownTimer = 0;
        int numActions = 1;
        public int keyPresses = 1;

        public bool toggle;
        bool isPaused = false;
        bool infinite = false;

        Object sender;
        ElapsedEventArgs a;
        DoWorkEventArgs b;
        ProgressChangedEventArgs c;
        RunWorkerCompletedEventArgs d;
        EventArgs e;

        public easyAutoClick()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            cbKeyboardOrMouse.SelectedIndex = 0;
            cbInfiniteOrFinite.SelectedIndex = 0;
            cbButtonChoice.SelectedIndex = 0;

            timer.WorkerReportsProgress = true;
            timer.WorkerSupportsCancellation = true;

            tbHours.Click += new EventHandler(tbHours_Enter);
            tbMinutes.Click += new EventHandler(tbMinutes_Enter);
            tbSeconds.Click += new EventHandler(tbSeconds_Enter);
            tbMilliseconds.Click += new EventHandler(tbMilliseconds_Enter);
            tbRepetitions.Click += new EventHandler(tbRepetitions_Enter);
        }

        private void InitializeBackgroundWorker() { timer.DoWork += new DoWorkEventHandler(Timer_DoWork); }
        private static void TimerEventProcessor(Object sender, EventArgs e) { }
        private void tbHours_Enter(Object sender, EventArgs e) { tbHours.SelectAll(); }
        private void tbMinutes_Enter(Object sender, EventArgs e) { tbMinutes.SelectAll(); }
        private void tbSeconds_Enter(Object sender, EventArgs e) { tbSeconds.SelectAll(); }
        private void tbMilliseconds_Enter(Object sender, EventArgs e) { tbMilliseconds.SelectAll(); }
        private void tbRepetitions_Enter(Object sender, EventArgs e) { tbRepetitions.SelectAll(); }

        private void timer_ProgressChanged(Object sender, ProgressChangedEventArgs e) { progressBar1.Value = e.ProgressPercentage; }
        private void tCountdownTimer_tick(Object sender, EventArgs e) {/*tCountdownTimer.Tick += new System.EventHandler(OnTimerEvent);*/}

        private void cbKeyboardOrMouse_SelectedIndexChanged(Object sender, EventArgs e) { if (cbKeyboardOrMouse.SelectedIndex == 0) { cbButtonChoice.Enabled = false; } else { cbButtonChoice.Enabled = true; } }
        private void cbInfiniteOrFinite_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (cbInfiniteOrFinite.SelectedIndex == 1)
            {
                tbRepetitions.Enabled = true;
            }
            else
            {
                tbRepetitions.Enabled = false;
            }
        }

        private void btnStart_Click(Object sender, EventArgs e)
        {
            this.timer.CancelAsync();
            if (int.TryParse(tbHours.Text, out numHours)) {/*Hours successfully parsed*/}
            if (int.TryParse(tbMinutes.Text, out numMinutes)) {/*Minutes successfully parsed*/}
            if (int.TryParse(tbSeconds.Text, out numSeconds)) {/*Seconds successfully parsed*/}
            if ((int.TryParse(tbMilliseconds.Text, out numMilliseconds))) {/*Milliseconds successfully parsed*/}
            if (cbKeyboardOrMouse.SelectedIndex == 1) { if (int.TryParse(tbKeyPresses.Text, out keyPresses)) {/*Key presses successfully parsed*/ } }
            //if (cbKeyboardOrMouse.SelectedIndex == 1) { mouseIsUsed = true; }
            if (numHours != 0 || numMinutes != 0 || numSeconds != 0 || numMilliseconds != 0)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                progressBar1.Enabled = false;
                tbHours.Enabled = false;
                tbMinutes.Enabled = false;
                tbSeconds.Enabled = false;
                tbMilliseconds.Enabled = false;
                tbKeyPresses.Enabled = false;
                tbRepetitions.Enabled = false;
                cbButtonChoice.Enabled = false;
                cbInfiniteOrFinite.Enabled = false;
                cbKeyboardOrMouse.Enabled = false;

                if (cbInfiniteOrFinite.SelectedIndex == 0)
                {
                    infinite = true;
                    timer.RunWorkerAsync();
                }
                else
                {
                    if (int.TryParse(tbRepetitions.Text, out numActions))
                    {
                        timer.RunWorkerAsync(numActions);
                    }
                    else MessageBox.Show("Please enter a repetition number if 'finite' is selected.");
                    btnStop_Click(sender, e);
                }
            }
        }

        private void StartAsyncButton_Click(Object sender, EventArgs e) { if (timer.IsBusy != true) { timer.RunWorkerAsync(); } }
        /*
                private void pauseAsyncButton_Click(Object sender, EventArgs e)
                {
                    if (isPaused == false)
                    {
                        btnPause.Text = "Unpause";
                        isPaused = true;
                        if (cts.Token.IsCancellationRequested == true)
                            {DoWorkAsync(cts.Token);}
                        if (cts1.Token.IsCancellationRequested == true)
                            {DoWorkAsync(cts1.Token);}
                    }
                    else if (isPaused == true)
                    {
                        btnPause.Text = "Pause";
                        isPaused = false;
                    }
                }
        */
        private void btnStop_Click(Object sender, EventArgs e)
        {
            tCountdownTimer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            progressBar1.Enabled = true;
            tbHours.Enabled = true;
            tbMinutes.Enabled = true;
            tbSeconds.Enabled = true;
            tbMilliseconds.Enabled = true;
            tbKeyPresses.Enabled = true;
            tbRepetitions.Enabled = true;
            cbInfiniteOrFinite.Enabled = true;
            cbKeyboardOrMouse.Enabled = true;
            if (cbKeyboardOrMouse.SelectedIndex != 1) { cbKeyboardOrMouse.Enabled = false; }
            this.timer.CancelAsync();
            CancellationToken cancellationToken = cts.Token;
            cts.Cancel();
        }

        private void StopAsyncButton_Click(Object sender, EventArgs e) { this.timer.CancelAsync(); }

        private async void Timer_DoWork(Object sender, DoWorkEventArgs e)
        {
            BackgroundWorker timer = sender as BackgroundWorker;
            countdownTimer = Time.TimeInputCalculation(numHours, numMinutes, numSeconds, numMilliseconds);
            if (infinite == true)
            {
                CancellationTokenSource cts3 = new();
                await DoWorkAsync(cts3.Token);
                for (int i = 1; i <= 2; i--)
                {
                    if (timer.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < keyPresses; j++) { PerformUserDefinedAction(); }
                        Debug.WriteLine("Timer completed at: " + DateTime.Now);
                        await DoWorkAsync(cts3.Token);
                        //timer.ReportProgress(i * 10);
                    }
                }
            }
            else
            {
                CancellationTokenSource cts4 = new();
                int numActionsLeft = numActions;
                await DoWorkAsync(cts4.Token);
                for (int i = 1; i <= numActions; i++)
                {
                    if (timer.CancellationPending == true)
                    {
                        e.Cancel = true;
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < keyPresses; j++) { PerformUserDefinedAction(); };
                        numActionsLeft--;
                        Debug.WriteLine("Timer completed at: " + DateTime.Now + ", " + numActionsLeft + " actions left");
                        await DoWorkAsync(cts4.Token);
                        //timer.ReportProgress(Math.Abs(i) * 10);
                    }
                }
            }
            this.Invoke((MethodInvoker)delegate
            {
                tCountdownTimer.Stop();
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                progressBar1.Enabled = true;
                tbHours.Enabled = true;
                tbMinutes.Enabled = true;
                tbSeconds.Enabled = true;
                tbMilliseconds.Enabled = true;
                tbKeyPresses.Enabled = true;
                tbRepetitions.Enabled = true;
                cbButtonChoice.Enabled = true;
                cbInfiniteOrFinite.Enabled = true;
                cbKeyboardOrMouse.Enabled = true;
            });
        }

        public void PerformUserDefinedAction()
        {
            int keyboardOrMouse = 1;
            int buttonChoice = 0;
            this.Invoke((MethodInvoker)delegate
            {
                keyboardOrMouse = cbKeyboardOrMouse.SelectedIndex;
                buttonChoice = cbButtonChoice.SelectedIndex;
            });
            if (keyboardOrMouse == 1)
            {
                if (buttonChoice == 0) { uint X = (uint)Cursor.Position.X; uint Y = (uint)Cursor.Position.Y; mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0); }
                else if (buttonChoice == 1) { uint X = (uint)Cursor.Position.X; uint Y = (uint)Cursor.Position.Y; mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0); }
                else if (buttonChoice == 2) { uint X = (uint)Cursor.Position.X; uint Y = (uint)Cursor.Position.Y; mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0); }
            }
            else
            {
                // Keyboard typing goes here
            }
        }

        public async Task DoWorkAsync(CancellationToken cancellationToken)
        {
            this.Invoke((MethodInvoker)delegate
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                progressBar1.Enabled = false;
                tbHours.Enabled = false;
                tbMinutes.Enabled = false;
                tbSeconds.Enabled = false;
                tbMilliseconds.Enabled = false;
                tbKeyPresses.Enabled = false;
                tbRepetitions.Enabled = false;
                cbButtonChoice.Enabled = false;
                cbInfiniteOrFinite.Enabled = false;
                cbKeyboardOrMouse.Enabled = false;
            });
            try
            {
                await Task.Delay(countdownTimer, cancellationToken);
                while (isPaused)
                {
                    await Task.Delay(250);
                }
            }
            catch (TaskCanceledException ex)
            {
                Debug.WriteLine("Task was canceled: " + ex.ToString());
            }
        }

        private void timer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs d)
        {
            if (d.Cancelled == true)
            {
                //lblTest.Text = "Canceled!";
            }
            else if (d.Error != null)
            {
                //lblTest.Text = "Error: " + d.Error.Message;
            }
            else
            {
                //lblTest.Text = "Done!";
            }
        }

        public void saveToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.txt";

            if (int.TryParse(tbKeyPresses.Text, out var keyPresses)) { }
            if (int.TryParse(tbRepetitions.Text, out var repetitions)) { }

            string settings = "Hours = " + tbHours.Text
                    + "\nMinutes = " + tbMinutes.Text
                    + "\nSeconds = " + tbSeconds.Text
                    + "\nMilliseconds = " + tbMilliseconds.Text
                    + "\nInput method = " + cbKeyboardOrMouse.SelectedIndex
                    + "\nButton choice = " + cbButtonChoice.SelectedIndex
                    + "\n# Key presses = " + keyPresses.ToString()
                    + "\nInfinite = " + cbInfiniteOrFinite.SelectedIndex
                    + "\n# Repeats = " + repetitions.ToString();

            byte[] data = Encoding.UTF8.GetBytes(settings);

            using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            { fs.Write(data, 0, settings.Length); }
            fs.Close();
        }

        public void openToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.txt";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                string singleString = Encoding.UTF8.GetString(data);
                string[] settings = singleString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string setting in settings)
                {
                    string[] keyValue = setting.Split(" = ");

                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0];
                        string value = keyValue[1];

                        if (key == "Hours") { tbHours.Text = value; }
                        if (key == "Minutes") { tbMinutes.Text = value; }
                        if (key == "Seconds") { tbSeconds.Text = value; }
                        if (key == "Milliseconds") { tbMilliseconds.Text = value; }
                        if (key == "Input method") { int.TryParse(value, out int numValue); cbKeyboardOrMouse.SelectedIndex = numValue; }
                        if (key == "Button choice") { int.TryParse(value, out int numValue); cbButtonChoice.SelectedIndex = numValue; }
                        if (key == "# Key presses") { tbKeyPresses.Text = value; }
                        if (key == "Infinite") { int.TryParse(value, out int numValue); cbInfiniteOrFinite.SelectedIndex = numValue; }
                        if (key == "# Repeats") { int.TryParse(value, out int numValue); tbRepetitions.Text = value; }
                    }
                }
                fs.Close();
            }

        }

        private void alwaysOnTopToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (alwaysOnTopToolStripMenuItem.Checked) { this.TopMost = true; }
            else if (!alwaysOnTopToolStripMenuItem.Checked) { this.TopMost = false; }
        }

        private void yesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.txt";
            if (File.Exists(path)) { File.Delete(path); Debug.WriteLine("File deleted successfully."); }
            else { MessageBox.Show("Failed to find file.", "Error", MessageBoxButtons.OK); }
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gitHubLink = "https://github.com/iNutti/Easy-Auto-Click/tree/master";
            Process.Start(new ProcessStartInfo(gitHubLink) { UseShellExecute = true });
        }

        private void patreonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string patreonLink = "youtube.com";
            Process.Start(new ProcessStartInfo(patreonLink) { UseShellExecute = true });
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        private void easyAutoClick_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (saveOnExitToolStripMenuItem.Checked) { saveToolStripMenuItem_Click(sender, e); }
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\menu.txt";
            string alwaysOnTopChecked = "false";
            string saveOnExitChecked = "false";
            string closeOnceFinished = "false";
            if (alwaysOnTopToolStripMenuItem.Checked == true) { alwaysOnTopChecked = "true"; }
            if (saveOnExitToolStripMenuItem.Checked == true) { saveOnExitChecked = "true"; }
            if (closeOnceFinishedToolStripMenuItem.Checked == true) { closeOnceFinished = "true"; }
            string menu = "Always on top: " + alwaysOnTopChecked + "\nSave on exit: " + saveOnExitChecked + "\nClose when done: " + closeOnceFinished;
            byte[] data = Encoding.UTF8.GetBytes(menu);
            using FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            { fs.Write(data, 0, menu.Length); }
            fs.Close();
        }

        private void easyAutoClick_Load(Object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\menu.txt";
            using (FileStream fs = new(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                string singleString = Encoding.UTF8.GetString(data);
                string[] menu = singleString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string menuItem in menu)
                {
                    string[] keyValue = menuItem.Split(": ");
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0];
                        string value = keyValue[1];

                        if (key == "Always on top") { if (value == "true") this.Invoke((MethodInvoker)delegate { alwaysOnTopToolStripMenuItem.Checked = true; }); }
                        if (key == "Save on exit") { if (value == "true") this.Invoke((MethodInvoker)delegate { saveOnExitToolStripMenuItem.Checked = true; }); }
                        if (key == "Close when done") { if (value == "true") this.Invoke((MethodInvoker)delegate { closeOnceFinishedToolStripMenuItem.Checked = true; }); }
                    }
                }
                fs.Close();
            }
            openToolStripMenuItem_Click(sender, e);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (toggle == false) { btnStop_Click(sender, e); toggle = true; } else { btnStart_Click(sender, e); toggle = false; }
        }
    }
}