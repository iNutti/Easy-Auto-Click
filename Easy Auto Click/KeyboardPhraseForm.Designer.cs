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
            tbPhrase.Location = new Point(12, 12);
            tbPhrase.Name = "tbPhrase";
            tbPhrase.Size = new Size(412, 23);
            tbPhrase.TabIndex = 0;
            tbPhrase.Text = "This feature does not currently work.";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(166, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 60);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // KeyboardPhraseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 143);
            Controls.Add(btnSave);
            Controls.Add(tbPhrase);
            Icon = (Icon)resources.GetObject("$this.Icon");
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