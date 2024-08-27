
namespace Easy_Auto_Click
{
    partial class easyAutoClick
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(easyAutoClick));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            resetSettingsToolStripMenuItem = new ToolStripMenuItem();
            areYouSureToolStripMenuItem = new ToolStripMenuItem();
            noToolStripMenuItem = new ToolStripMenuItem();
            yesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            saveOnExitToolStripMenuItem = new ToolStripMenuItem();
            closeOnceFinishedToolStripMenuItem = new ToolStripMenuItem();
            keyboardTypingToolStripMenuItem = new ToolStripMenuItem();
            hotkeysToolStripMenuItem = new ToolStripMenuItem();
            supportToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            patreonToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnStart = new Button();
            progressBar1 = new ProgressBar();
            btnStop = new Button();
            tbHours = new TextBox();
            tbMinutes = new TextBox();
            gbInterval = new GroupBox();
            tbMilliseconds = new TextBox();
            tbSeconds = new TextBox();
            ntStatus = new NotifyIcon(components);
            tCountdownTimer = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            tbRepetitions = new TextBox();
            cbInfiniteOrFinite = new ComboBox();
            groupBox2 = new GroupBox();
            tbKeyPresses = new TextBox();
            cbButtonChoice = new ComboBox();
            cbKeyboardOrMouse = new ComboBox();
            timer = new System.ComponentModel.BackgroundWorker();
            btnToggle = new Button();
            menuStrip1.SuspendLayout();
            gbInterval.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, supportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(713, 46);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem, resetSettingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8F);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(67, 38);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(359, 44);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(359, 44);
            openToolStripMenuItem.Text = "&Load";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // resetSettingsToolStripMenuItem
            // 
            resetSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { areYouSureToolStripMenuItem, noToolStripMenuItem, yesToolStripMenuItem });
            resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            resetSettingsToolStripMenuItem.Size = new Size(359, 44);
            resetSettingsToolStripMenuItem.Text = "Reset settings";
            // 
            // areYouSureToolStripMenuItem
            // 
            areYouSureToolStripMenuItem.Name = "areYouSureToolStripMenuItem";
            areYouSureToolStripMenuItem.Size = new Size(278, 44);
            areYouSureToolStripMenuItem.Text = "Are you sure?";
            // 
            // noToolStripMenuItem
            // 
            noToolStripMenuItem.Name = "noToolStripMenuItem";
            noToolStripMenuItem.Size = new Size(278, 44);
            noToolStripMenuItem.Text = "No";
            // 
            // yesToolStripMenuItem
            // 
            yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            yesToolStripMenuItem.Size = new Size(278, 44);
            yesToolStripMenuItem.Text = "Yes";
            yesToolStripMenuItem.Click += yesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(359, 44);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopToolStripMenuItem, saveOnExitToolStripMenuItem, closeOnceFinishedToolStripMenuItem, keyboardTypingToolStripMenuItem, hotkeysToolStripMenuItem });
            optionsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8F);
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(107, 38);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(359, 44);
            alwaysOnTopToolStripMenuItem.Text = "Always on top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // saveOnExitToolStripMenuItem
            // 
            saveOnExitToolStripMenuItem.CheckOnClick = true;
            saveOnExitToolStripMenuItem.Name = "saveOnExitToolStripMenuItem";
            saveOnExitToolStripMenuItem.Size = new Size(359, 44);
            saveOnExitToolStripMenuItem.Text = "Save on exit";
            // 
            // closeOnceFinishedToolStripMenuItem
            // 
            closeOnceFinishedToolStripMenuItem.CheckOnClick = true;
            closeOnceFinishedToolStripMenuItem.Name = "closeOnceFinishedToolStripMenuItem";
            closeOnceFinishedToolStripMenuItem.Size = new Size(359, 44);
            closeOnceFinishedToolStripMenuItem.Text = "Close when done";
            // 
            // keyboardTypingToolStripMenuItem
            // 
            keyboardTypingToolStripMenuItem.Name = "keyboardTypingToolStripMenuItem";
            keyboardTypingToolStripMenuItem.Size = new Size(359, 44);
            keyboardTypingToolStripMenuItem.Text = "Keyboard phrase";
            keyboardTypingToolStripMenuItem.Click += keyboardTypingToolStripMenuItem_Click;
            // 
            // hotkeysToolStripMenuItem
            // 
            hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            hotkeysToolStripMenuItem.Size = new Size(359, 44);
            hotkeysToolStripMenuItem.Text = "Hotkeys (WIP)";
            hotkeysToolStripMenuItem.Click += hotkeysToolStripMenuItem_Click;
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem, patreonToolStripMenuItem });
            supportToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8F);
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new Size(108, 38);
            supportToolStripMenuItem.Text = "&Support";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(219, 44);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // patreonToolStripMenuItem
            // 
            patreonToolStripMenuItem.Name = "patreonToolStripMenuItem";
            patreonToolStripMenuItem.Size = new Size(219, 44);
            patreonToolStripMenuItem.Text = "Patreon";
            patreonToolStripMenuItem.Click += patreonToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(22, 617);
            btnStart.Margin = new Padding(6, 6, 6, 6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(186, 128);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 58);
            progressBar1.Margin = new Padding(6, 6, 6, 6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(713, 710);
            progressBar1.TabIndex = 10;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(505, 617);
            btnStop.Margin = new Padding(6, 6, 6, 6);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(186, 128);
            btnStop.TabIndex = 2;
            btnStop.Text = "S&top";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // tbHours
            // 
            tbHours.Font = new Font("Microsoft Sans Serif", 10F);
            tbHours.Location = new Point(11, 45);
            tbHours.Margin = new Padding(6, 6, 6, 6);
            tbHours.Name = "tbHours";
            tbHours.Size = new Size(186, 38);
            tbHours.TabIndex = 0;
            tbHours.Text = "Hours";
            tbHours.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMinutes
            // 
            tbMinutes.Font = new Font("Microsoft Sans Serif", 10F);
            tbMinutes.Location = new Point(11, 109);
            tbMinutes.Margin = new Padding(6, 6, 6, 6);
            tbMinutes.Name = "tbMinutes";
            tbMinutes.Size = new Size(186, 38);
            tbMinutes.TabIndex = 1;
            tbMinutes.Text = "Minutes";
            tbMinutes.TextAlign = HorizontalAlignment.Center;
            // 
            // gbInterval
            // 
            gbInterval.Controls.Add(tbMilliseconds);
            gbInterval.Controls.Add(tbSeconds);
            gbInterval.Controls.Add(tbHours);
            gbInterval.Controls.Add(tbMinutes);
            gbInterval.Location = new Point(22, 92);
            gbInterval.Margin = new Padding(6, 6, 6, 6);
            gbInterval.Name = "gbInterval";
            gbInterval.Padding = new Padding(6, 6, 6, 6);
            gbInterval.Size = new Size(212, 320);
            gbInterval.TabIndex = 7;
            gbInterval.TabStop = false;
            gbInterval.Text = "Interval";
            // 
            // tbMilliseconds
            // 
            tbMilliseconds.Font = new Font("Microsoft Sans Serif", 10F);
            tbMilliseconds.Location = new Point(11, 237);
            tbMilliseconds.Margin = new Padding(6, 6, 6, 6);
            tbMilliseconds.Name = "tbMilliseconds";
            tbMilliseconds.Size = new Size(186, 38);
            tbMilliseconds.TabIndex = 3;
            tbMilliseconds.Text = "Milliseconds";
            tbMilliseconds.TextAlign = HorizontalAlignment.Center;
            // 
            // tbSeconds
            // 
            tbSeconds.Font = new Font("Microsoft Sans Serif", 10F);
            tbSeconds.Location = new Point(11, 173);
            tbSeconds.Margin = new Padding(6, 6, 6, 6);
            tbSeconds.Name = "tbSeconds";
            tbSeconds.Size = new Size(186, 38);
            tbSeconds.TabIndex = 2;
            tbSeconds.Text = "Seconds";
            tbSeconds.TextAlign = HorizontalAlignment.Center;
            // 
            // ntStatus
            // 
            ntStatus.Text = ":)";
            ntStatus.Visible = true;
            // 
            // tCountdownTimer
            // 
            tCountdownTimer.Interval = 1000;
            tCountdownTimer.Tick += tCountdownTimer_tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbRepetitions);
            groupBox1.Controls.Add(cbInfiniteOrFinite);
            groupBox1.Location = new Point(479, 92);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(212, 320);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Repetition";
            // 
            // tbRepetitions
            // 
            tbRepetitions.Enabled = false;
            tbRepetitions.Font = new Font("Microsoft Sans Serif", 10F);
            tbRepetitions.Location = new Point(11, 111);
            tbRepetitions.Margin = new Padding(6, 6, 6, 6);
            tbRepetitions.Name = "tbRepetitions";
            tbRepetitions.Size = new Size(186, 38);
            tbRepetitions.TabIndex = 4;
            tbRepetitions.Text = "Repetitions";
            tbRepetitions.TextAlign = HorizontalAlignment.Center;
            // 
            // cbInfiniteOrFinite
            // 
            cbInfiniteOrFinite.FormattingEnabled = true;
            cbInfiniteOrFinite.Items.AddRange(new object[] { "Infinite", "Finite" });
            cbInfiniteOrFinite.Location = new Point(11, 49);
            cbInfiniteOrFinite.Margin = new Padding(6, 6, 6, 6);
            cbInfiniteOrFinite.Name = "cbInfiniteOrFinite";
            cbInfiniteOrFinite.Size = new Size(186, 40);
            cbInfiniteOrFinite.TabIndex = 3;
            cbInfiniteOrFinite.SelectedIndexChanged += cbInfiniteOrFinite_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbKeyPresses);
            groupBox2.Controls.Add(cbButtonChoice);
            groupBox2.Controls.Add(cbKeyboardOrMouse);
            groupBox2.Location = new Point(251, 92);
            groupBox2.Margin = new Padding(6, 6, 6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6, 6, 6, 6);
            groupBox2.Size = new Size(212, 320);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hotkey";
            // 
            // tbKeyPresses
            // 
            tbKeyPresses.Font = new Font("Microsoft Sans Serif", 10F);
            tbKeyPresses.Location = new Point(11, 173);
            tbKeyPresses.Margin = new Padding(6, 6, 6, 6);
            tbKeyPresses.Name = "tbKeyPresses";
            tbKeyPresses.Size = new Size(186, 38);
            tbKeyPresses.TabIndex = 5;
            tbKeyPresses.Text = "# key presses";
            tbKeyPresses.TextAlign = HorizontalAlignment.Center;
            // 
            // cbButtonChoice
            // 
            cbButtonChoice.FormattingEnabled = true;
            cbButtonChoice.Items.AddRange(new object[] { "Left mouse", "Right mouse", "Middle mouse" });
            cbButtonChoice.Location = new Point(11, 109);
            cbButtonChoice.Margin = new Padding(6, 6, 6, 6);
            cbButtonChoice.Name = "cbButtonChoice";
            cbButtonChoice.Size = new Size(186, 40);
            cbButtonChoice.TabIndex = 1;
            // 
            // cbKeyboardOrMouse
            // 
            cbKeyboardOrMouse.AutoCompleteCustomSource.AddRange(new string[] { "Mouse", "Keyboard" });
            cbKeyboardOrMouse.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbKeyboardOrMouse.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKeyboardOrMouse.FormattingEnabled = true;
            cbKeyboardOrMouse.Items.AddRange(new object[] { "Keyboard (WIP)", "Mouse" });
            cbKeyboardOrMouse.Location = new Point(11, 49);
            cbKeyboardOrMouse.Margin = new Padding(6, 6, 6, 6);
            cbKeyboardOrMouse.Name = "cbKeyboardOrMouse";
            cbKeyboardOrMouse.Size = new Size(186, 40);
            cbKeyboardOrMouse.TabIndex = 0;
            cbKeyboardOrMouse.SelectedIndexChanged += cbKeyboardOrMouse_SelectedIndexChanged;
            // 
            // btnToggle
            // 
            btnToggle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToggle.Location = new Point(264, 617);
            btnToggle.Margin = new Padding(6, 6, 6, 6);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(186, 128);
            btnToggle.TabIndex = 13;
            btnToggle.Text = "&Toggle";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // easyAutoClick
            // 
            AccessibleDescription = "Easy Auto Click";
            AccessibleName = "Easy Auto Click";
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 770);
            Controls.Add(btnToggle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbInterval);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(menuStrip1);
            Controls.Add(progressBar1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            Name = "easyAutoClick";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Automation made simple! :)";
            FormClosing += easyAutoClick_FormClosing;
            Load += easyAutoClick_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbInterval.ResumeLayout(false);
            gbInterval.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem supportToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnStart;
        private ProgressBar progressBar1;
        private Button btnStop;
        private TextBox tbHours;
        private TextBox tbMinutes;
        private GroupBox gbInterval;
        private TextBox tbMilliseconds;
        private TextBox tbSeconds;
        private NotifyIcon ntStatus;
        private System.Windows.Forms.Timer tCountdownTimer;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbRepetitions;
        private ComboBox cbInfiniteOrFinite;
        private TextBox tbKeyPresses;
        private ToolStripMenuItem resetSettingsToolStripMenuItem;
        private ToolStripMenuItem areYouSureToolStripMenuItem;
        private ToolStripMenuItem noToolStripMenuItem;
        private ToolStripMenuItem yesToolStripMenuItem;
        private ToolStripMenuItem saveOnExitToolStripMenuItem;
        private ToolStripMenuItem closeOnceFinishedToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem patreonToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker timer;
        public ComboBox cbButtonChoice;
        public ComboBox cbKeyboardOrMouse;
        private Button btnToggle;
        private ToolStripMenuItem keyboardTypingToolStripMenuItem;
        private ToolStripMenuItem hotkeysToolStripMenuItem;
    }
}
