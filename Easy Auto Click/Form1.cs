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

        public string startHotkey = "F7";
        public string toggleHotkey = "F8";
        public string stopHotkey = "F9";
        public string keyBoardPhrase = "Hello world!";
        public string userDefinedKeys = "a";

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
        FormClosingEventArgs f;

        public easyAutoClick()
        {
            InitializeComponent();
            InitializeBackgroundWorker();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Hotkey_KeyDown);

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
            tbKeyPresses.Click += new EventHandler(tbKeyPresses_Enter);

            btnStart.Text = "&Start\n" + startHotkey;
            btnToggle.Text = "&Toggle\n" + toggleHotkey;
            btnStop.Text = "&Stop\n" + stopHotkey;

            cbKeyboardOrMouse.SelectedIndex = 1;
        }

        private void InitializeBackgroundWorker() { timer.DoWork += new DoWorkEventHandler(Timer_DoWork); }
        private static void TimerEventProcessor(Object sender, EventArgs e) { }
        private void tbHours_Enter(Object sender, EventArgs e) { tbHours.SelectAll(); }
        private void tbMinutes_Enter(Object sender, EventArgs e) { tbMinutes.SelectAll(); }
        private void tbSeconds_Enter(Object sender, EventArgs e) { tbSeconds.SelectAll(); }
        private void tbMilliseconds_Enter(Object sender, EventArgs e) { tbMilliseconds.SelectAll(); }
        private void tbRepetitions_Enter(Object sender, EventArgs e) { tbRepetitions.SelectAll(); }
        private void tbKeyPresses_Enter(Object sender, EventArgs e) { tbKeyPresses.SelectAll(); }

        private void timer_ProgressChanged(Object sender, ProgressChangedEventArgs e) { progressBar1.Value = e.ProgressPercentage; }
        private void tCountdownTimer_tick(Object sender, EventArgs e) {/*tCountdownTimer.Tick += new System.EventHandler(OnTimerEvent);*/}

        private void cbKeyboardOrMouse_SelectedIndexChanged(Object sender, EventArgs e) { if (cbKeyboardOrMouse.SelectedIndex == 0) { cbButtonChoice.Enabled = false; tbRepetitions.Enabled = false; } else { cbButtonChoice.Enabled = true; } }
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

        // Everything begins here
        private void btnStart_Click(Object sender, EventArgs e) 
        {
            Phrase_Load(); // Load the phrase on every start.

            // Find the install path and open the keyboard phrase file. This is a workaround cus I'm not C# smart yet.
            if (cbKeyboardOrMouse.SelectedIndex == 0)
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

                            if (key == "Phrase") { userDefinedKeys = value; }
                        }
                    }
                    fs.Close();
                }

            }

            // Cancel any previous timer
            this.timer.CancelAsync();

            if (int.TryParse(tbHours.Text, out numHours)) {/*Hours successfully parsed*/}
            if (int.TryParse(tbMinutes.Text, out numMinutes)) {/*Minutes successfully parsed*/}
            if (int.TryParse(tbSeconds.Text, out numSeconds)) {/*Seconds successfully parsed*/}
            if ((int.TryParse(tbMilliseconds.Text, out numMilliseconds))) {/*Milliseconds successfully parsed*/}
            if (cbKeyboardOrMouse.SelectedIndex == 1) { if (int.TryParse(tbKeyPresses.Text, out keyPresses)) {/*Key presses successfully parsed*/ } }
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

        // Start asynchronus task so the form doesn't lock up.
        private void StartAsyncButton_Click(Object sender, EventArgs e) { if (timer.IsBusy != true) { timer.RunWorkerAsync(); } }

        // Stop all previous work, no pause
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
            cbInfiniteOrFinite.Enabled = true;
            cbKeyboardOrMouse.Enabled = true;
            if (cbKeyboardOrMouse.SelectedIndex != 1) { cbButtonChoice.Enabled = false; }
            if (cbInfiniteOrFinite.SelectedIndex == 1) { tbRepetitions.Enabled = true; }
            this.timer.CancelAsync();
            CancellationToken cancellationToken = cts.Token;
            cts.Cancel();
        }

        // WIP - Stops background timer.
        private void StopAsyncButton_Click(Object sender, EventArgs e) { this.timer.CancelAsync(); }

        // Here is where we count down. Run async so the form does not lock.
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

        // Timer countdown results in either mouse click or typed out phrase.
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
                if (cbButtonChoice.SelectedIndex == 0) { uint X = (uint)Cursor.Position.X; uint Y = (uint)Cursor.Position.Y; mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0); }
                else if (cbButtonChoice.SelectedIndex == 1) { uint X = (uint)Cursor.Position.X; uint Y = (uint)Cursor.Position.Y; mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0); }
                else if (cbButtonChoice.SelectedIndex == 2) { uint X = (uint)Cursor.Position.X; uint Y = (uint)Cursor.Position.Y; mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, X, Y, 0, 0); }
            }
            else
            {
                Debug.WriteLine(userDefinedKeys);
                SendKeys.SendWait(userDefinedKeys + "{ENTER}");
            }
        }

        // Adds pause ability
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
                // The meat of this class - the countdownTimer variable is set back in the Timer_DoWork class.
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

        // Does not currently serve a purpose.
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

        // Self explanatory class name.
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

        // File > Load option in the toolstrip menu.
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
                        if (key == "Phrase") { keyBoardPhrase = value; }
                    }
                }
                fs.Close();
            }
            if (cbKeyboardOrMouse.SelectedIndex == 0) { this.Invoke((MethodInvoker)delegate { cbButtonChoice.Enabled = false; }); }
            if (cbInfiniteOrFinite.SelectedIndex == 0) { this.Invoke((MethodInvoker)delegate { tbRepetitions.Enabled = false; tbRepetitions.Text = "Repititions"; }); }
        }

        // Always on top option.
        private void alwaysOnTopToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (alwaysOnTopToolStripMenuItem.Checked) { this.TopMost = true; }
            else if (!alwaysOnTopToolStripMenuItem.Checked) { this.TopMost = false; }
        }

        // File > Reset > Yes in the toolstrip menu. Deletes the settings file.
        private void yesToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.txt";
            if (File.Exists(path)) { File.Delete(path); Debug.WriteLine("File deleted successfully."); }
            else { MessageBox.Show("Failed to find file.", "Error", MessageBoxButtons.OK); }
            // Unchecking this since it would be confusing to delete settings but then settings get re-saved anyways.
            saveOnExitToolStripMenuItem.Checked = false;
        }

        // Github web link.
        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string gitHubLink = "https://github.com/iNutti/Easy-Auto-Click/tree/master";
            Process.Start(new ProcessStartInfo(gitHubLink) { UseShellExecute = true });
        }

        // Patreon web link.
        private void patreonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string patreonLink = "https://www.patreon.com/inutti";
            Process.Start(new ProcessStartInfo(patreonLink) { UseShellExecute = true });
        }

        // Close program from menu.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

        // Form load events. Mostly for loading settings into boxes.
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
                        if (key == "Phrase") { userDefinedKeys = value; } else { }
                    }
                }
                fs.Close();
            }
            openToolStripMenuItem_Click(sender, e);
        }

        // Form close events. Mostly for save on close toolstrip menu item.
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

        // Toggle start or stop.
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (toggle == false) { btnStop_Click(sender, e); toggle = true; } else { btnStart_Click(sender, e); toggle = false; }
        }

        // Loads keyboardphraseform.
        public void keyboardTypingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyboardPhraseForm keyboardPhraseForm = new KeyboardPhraseForm();
            keyboardPhraseForm.StartPosition = FormStartPosition.Manual;
            keyboardPhraseForm.Location = new Point(this.Location.X + 0, this.Location.Y + 0);
            keyboardPhraseForm.Show();
        }

        // For hotkeys to toggle form buttons.
        private void Hotkey_KeyDown(Object sender, KeyEventArgs e)
        {
            // Start function
            if (e.KeyCode == Keys.F7) { btnStart_Click(sender, e); }
            // Toggle function
            if (e.KeyCode == Keys.F8) { btnToggle_Click(sender, e); }
            // Stop function
            if (e.KeyCode == Keys.F9) { btnStop_Click(sender, e); }
        }

        // WIP - Allows the user to define their own hotkeys for form buttons.
        private void hotkeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // WIP. Let user change start, toggle, stop hotkeys.
        }
        
        // Used in btnStart_Click. Loads the keyboard phrase every time the start function is used.
        private void Phrase_Load()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.txt";
            bool bPhraseExist = false;

            if (Path.Exists(path)) // Does the settings file exist? Let's not create a new one if it does.
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    string singleString = Encoding.UTF8.GetString(data);
                    string[] settings = singleString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    // Load settings file
                    foreach (string setting in settings)
                    {
                        string[] keyValue = setting.Split(" = ");

                        if (keyValue.Length == 2)
                        {
                            string key = keyValue[0];
                            string value = keyValue[1];

                            // Does the phrase setting exist?
                            if (key == "Phrase")
                            {
                                userDefinedKeys = value;
                            }
                            else
                            {
                                // Do nothing.
                            }
                        }
                    }
                    fs.Close(); // Close the connection to the file before reading all lines in.
                }
            }
            else // So the settings.txt file does not exist. Let's create it!
            {
                bPhraseExist = false;
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Read))
                {
                    byte[] data = new byte[fs.Length];
                    fs.Read(data, 0, data.Length);
                    string singleString = Encoding.UTF8.GetString(data);
                    string[] settings = singleString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    // Load settings file
                    foreach (string setting in settings)
                    {
                        string[] keyValue = setting.Split(" = ");

                        if (keyValue.Length == 2)
                        {
                            string key = keyValue[0];
                            string value = keyValue[1];

                            // Does the phrase setting exist?
                            if (key == "Phrase")
                            {
                                userDefinedKeys = value;
                            }
                            else
                            {
                                // Do nothing.
                            }
                        }
                    }
                    fs.Close(); // Close the connection to the file before reading all lines in.
                }

            }
        }
    }
}