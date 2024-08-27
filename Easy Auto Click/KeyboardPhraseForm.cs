using System.Text;

namespace Easy_Auto_Click
{
    public partial class KeyboardPhraseForm : Form
    {
        public KeyboardPhraseForm()
        {
            InitializeComponent();
            KeyBoardPhraseForm_Load(); // Activate phrase load.
        }

        public void KeyboardPhraseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }// Closes the phrase form and nothing else.

        private void KeyBoardPhraseForm_Load()
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
                                tbPhrase.Text = value;
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
                                tbPhrase.Text = value;
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
        }// Loads the last used phrase into the text box for easier editing.

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\settings.txt";
            bool bPhraseExist = false;
            string userPhrase = "\nPhrase = " + (tbPhrase.Text);


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
                                bPhraseExist = true;
                            }
                            else
                            {
                                bPhraseExist = false;
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
                                bPhraseExist = true;
                            }
                            else
                            {
                                bPhraseExist = false;
                            }
                        }
                    }
                    fs.Close(); // Close the connection to the file before reading all lines in.
                }
            }

            if (bPhraseExist == true)
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));

                // Check if the file is not empty
                if (lines.Count > 0)
                {
                    // Modify the last line
                    lines[lines.Count - 1] = "Phrase = " + tbPhrase.Text;

                    // Write the modified lines back to the file
                    File.WriteAllLines(path, lines);
                }
            }
            this.Close();
        }// Save the phrase to the settings.txt file.

        private void Enter(object sender, KeyPressEventArgs e)
        {
            btnSave_Click(sender, e);
        }// Enter activates the Save function for this form.
    }
}
