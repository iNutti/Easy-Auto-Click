using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Easy_Auto_Click
{
    public partial class KeyboardPhraseForm : Form
    {
        public KeyboardPhraseForm()
        {
            InitializeComponent();
        }

        public void KeyboardPhraseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Recieved text: " + this.tbPhrase.Text);
        }
    }
}
