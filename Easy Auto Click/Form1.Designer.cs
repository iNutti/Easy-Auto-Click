
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
            supportToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            patreonToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnStart = new Button();
            progressBar1 = new ProgressBar();
            btnStop = new Button();
            btnPause = new Button();
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
            menuStrip1.SuspendLayout();
            gbInterval.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, supportToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, openToolStripMenuItem, resetSettingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Montserrat", 8F);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(151, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(151, 22);
            openToolStripMenuItem.Text = "&Load";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // resetSettingsToolStripMenuItem
            // 
            resetSettingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { areYouSureToolStripMenuItem, noToolStripMenuItem, yesToolStripMenuItem });
            resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            resetSettingsToolStripMenuItem.Size = new Size(151, 22);
            resetSettingsToolStripMenuItem.Text = "Reset settings";
            // 
            // areYouSureToolStripMenuItem
            // 
            areYouSureToolStripMenuItem.Name = "areYouSureToolStripMenuItem";
            areYouSureToolStripMenuItem.Size = new Size(147, 22);
            areYouSureToolStripMenuItem.Text = "Are you sure?";
            // 
            // noToolStripMenuItem
            // 
            noToolStripMenuItem.Name = "noToolStripMenuItem";
            noToolStripMenuItem.Size = new Size(147, 22);
            noToolStripMenuItem.Text = "No";
            // 
            // yesToolStripMenuItem
            // 
            yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            yesToolStripMenuItem.Size = new Size(147, 22);
            yesToolStripMenuItem.Text = "Yes";
            yesToolStripMenuItem.Click += yesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(151, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopToolStripMenuItem, saveOnExitToolStripMenuItem, closeOnceFinishedToolStripMenuItem });
            optionsToolStripMenuItem.Font = new Font("Montserrat", 8F);
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(180, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always on top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // saveOnExitToolStripMenuItem
            // 
            saveOnExitToolStripMenuItem.CheckOnClick = true;
            saveOnExitToolStripMenuItem.Name = "saveOnExitToolStripMenuItem";
            saveOnExitToolStripMenuItem.Size = new Size(180, 22);
            saveOnExitToolStripMenuItem.Text = "Save on exit";
            // 
            // closeOnceFinishedToolStripMenuItem
            // 
            closeOnceFinishedToolStripMenuItem.CheckOnClick = true;
            closeOnceFinishedToolStripMenuItem.Name = "closeOnceFinishedToolStripMenuItem";
            closeOnceFinishedToolStripMenuItem.Size = new Size(180, 22);
            closeOnceFinishedToolStripMenuItem.Text = "Close when done";
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem, patreonToolStripMenuItem });
            supportToolStripMenuItem.Font = new Font("Montserrat", 8F);
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new Size(62, 20);
            supportToolStripMenuItem.Text = "&Support";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(180, 22);
            githubToolStripMenuItem.Text = "Github";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // patreonToolStripMenuItem
            // 
            patreonToolStripMenuItem.Name = "patreonToolStripMenuItem";
            patreonToolStripMenuItem.Size = new Size(180, 22);
            patreonToolStripMenuItem.Text = "Patreon";
            patreonToolStripMenuItem.Click += patreonToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(12, 289);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 60);
            btnStart.TabIndex = 0;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 27);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(384, 333);
            progressBar1.TabIndex = 10;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(272, 289);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 60);
            btnStop.TabIndex = 2;
            btnStop.Text = "S&top";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.Enabled = false;
            btnPause.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPause.Location = new Point(142, 289);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(100, 60);
            btnPause.TabIndex = 1;
            btnPause.Text = "&Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // tbHours
            // 
            tbHours.Font = new Font("Montserrat", 10F);
            tbHours.Location = new Point(6, 21);
            tbHours.Name = "tbHours";
            tbHours.Size = new Size(102, 24);
            tbHours.TabIndex = 0;
            tbHours.Text = "Hours";
            tbHours.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMinutes
            // 
            tbMinutes.Font = new Font("Montserrat", 10F);
            tbMinutes.Location = new Point(6, 51);
            tbMinutes.Name = "tbMinutes";
            tbMinutes.Size = new Size(102, 24);
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
            gbInterval.Location = new Point(12, 43);
            gbInterval.Name = "gbInterval";
            gbInterval.Size = new Size(114, 150);
            gbInterval.TabIndex = 7;
            gbInterval.TabStop = false;
            gbInterval.Text = "Interval";
            // 
            // tbMilliseconds
            // 
            tbMilliseconds.Font = new Font("Montserrat", 10F);
            tbMilliseconds.Location = new Point(6, 111);
            tbMilliseconds.Name = "tbMilliseconds";
            tbMilliseconds.Size = new Size(102, 24);
            tbMilliseconds.TabIndex = 3;
            tbMilliseconds.Text = "Milliseconds";
            tbMilliseconds.TextAlign = HorizontalAlignment.Center;
            // 
            // tbSeconds
            // 
            tbSeconds.Font = new Font("Montserrat", 10F);
            tbSeconds.Location = new Point(6, 81);
            tbSeconds.Name = "tbSeconds";
            tbSeconds.Size = new Size(102, 24);
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
            groupBox1.Location = new Point(258, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(114, 150);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Repetition";
            // 
            // tbRepetitions
            // 
            tbRepetitions.Enabled = false;
            tbRepetitions.Font = new Font("Montserrat", 10F);
            tbRepetitions.Location = new Point(6, 52);
            tbRepetitions.Name = "tbRepetitions";
            tbRepetitions.Size = new Size(102, 24);
            tbRepetitions.TabIndex = 4;
            tbRepetitions.Text = "Repetitions";
            tbRepetitions.TextAlign = HorizontalAlignment.Center;
            // 
            // cbInfiniteOrFinite
            // 
            cbInfiniteOrFinite.FormattingEnabled = true;
            cbInfiniteOrFinite.Items.AddRange(new object[] { "Infinite", "Finite" });
            cbInfiniteOrFinite.Location = new Point(6, 23);
            cbInfiniteOrFinite.Name = "cbInfiniteOrFinite";
            cbInfiniteOrFinite.Size = new Size(102, 23);
            cbInfiniteOrFinite.TabIndex = 3;
            cbInfiniteOrFinite.SelectedIndexChanged += cbInfiniteOrFinite_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbKeyPresses);
            groupBox2.Controls.Add(cbButtonChoice);
            groupBox2.Controls.Add(cbKeyboardOrMouse);
            groupBox2.Location = new Point(135, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 150);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hotkey";
            // 
            // tbKeyPresses
            // 
            tbKeyPresses.Font = new Font("Montserrat", 10F);
            tbKeyPresses.Location = new Point(6, 81);
            tbKeyPresses.Name = "tbKeyPresses";
            tbKeyPresses.Size = new Size(102, 24);
            tbKeyPresses.TabIndex = 5;
            tbKeyPresses.Text = "# key presses";
            tbKeyPresses.TextAlign = HorizontalAlignment.Center;
            // 
            // cbButtonChoice
            // 
            cbButtonChoice.FormattingEnabled = true;
            cbButtonChoice.Items.AddRange(new object[] { "Left mouse", "Right mouse", "Middle mouse" });
            cbButtonChoice.Location = new Point(6, 51);
            cbButtonChoice.Name = "cbButtonChoice";
            cbButtonChoice.Size = new Size(102, 23);
            cbButtonChoice.TabIndex = 1;
            // 
            // cbKeyboardOrMouse
            // 
            cbKeyboardOrMouse.AutoCompleteCustomSource.AddRange(new string[] { "Mouse", "Keyboard" });
            cbKeyboardOrMouse.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbKeyboardOrMouse.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKeyboardOrMouse.FormattingEnabled = true;
            cbKeyboardOrMouse.Items.AddRange(new object[] { "Keyboard", "Mouse" });
            cbKeyboardOrMouse.Location = new Point(6, 23);
            cbKeyboardOrMouse.Name = "cbKeyboardOrMouse";
            cbKeyboardOrMouse.Size = new Size(102, 23);
            cbKeyboardOrMouse.TabIndex = 0;
            // 
            // easyAutoClick
            // 
            AccessibleDescription = "Easy Auto Click";
            AccessibleName = "Easy Auto Click";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbInterval);
            Controls.Add(btnPause);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(menuStrip1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
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
        private Button btnPause;
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
        private ComboBox cbButtonChoice;
        private ComboBox cbKeyboardOrMouse;
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
    }
}
