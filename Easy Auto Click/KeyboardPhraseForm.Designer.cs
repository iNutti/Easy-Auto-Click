namespace Easy_Auto_Click
{
    partial class KeyboardPhraseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyboardPhraseForm));
            tbPhrase = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbPhrase
            // 
            tbPhrase.AcceptsReturn = true;
            tbPhrase.Location = new Point(22, 26);
            tbPhrase.Margin = new Padding(6);
            tbPhrase.Multiline = true;
            tbPhrase.Name = "tbPhrase";
            tbPhrase.Size = new Size(762, 39);
            tbPhrase.TabIndex = 0;
            tbPhrase.Text = "What do you want to say?";
            tbPhrase.KeyPress += Enter;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(308, 127);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(186, 128);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // KeyboardPhraseForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 305);
            Controls.Add(btnSave);
            Controls.Add(tbPhrase);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "KeyboardPhraseForm";
            Text = "Type out a phrase!";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPhrase;
        private Button btnSave;
    }
}