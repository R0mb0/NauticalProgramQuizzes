using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DefinitiveNauticalProject.Editor;

namespace DefinitiveNauticalProject.Password
{
    public partial class PasswordPanel : Form
    {
        /*Private fields*/
        private ChangePassword change;
        private QuestionsEditor editor;

        /*Builder*/
        public PasswordPanel()
        {
            InitializeComponent();
            this.change = new ChangePassword();
            this.editor = new QuestionsEditor();
        }

        /*Button to start teh editori panel*/
        private void editorButton_Click(object sender, EventArgs e)
        {
            /*Password control*/
            if (this.passwordTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Password non valida");
                return;
            }

            if (System.IO.File.Exists("Password.pw"))
            {
                String json = File.ReadAllText("Password.pw");
                string password = JsonConvert.DeserializeObject<string>(json);

                if(this.passwordTextBox.Text == Crypter.Decrypt(password))
                {
                    editor.ShowDialog();
                    this.passwordTextBox.Clear();
                    this.Close();
                    return;
                }
                
                    MessageBox.Show("Password Sbagliata");
                return;
                
            }

            MessageBox.Show("Non trovaato il file password, accesso negato.");
        }

        /*Button to change the password*/
        private void passwordButton_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Password.pw"))
            {
                this.change.ShowDialog();
            }
            else
            {
                MessageBox.Show("Non trovaato il file password, accesso negato.");
            }

        }
    }
}
