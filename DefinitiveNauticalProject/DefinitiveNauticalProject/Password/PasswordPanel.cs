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
        private ChangePassword change;
        private QuestionsEditor editor;

        public PasswordPanel()
        {
            InitializeComponent();
            this.change = new ChangePassword();
            this.editor = new QuestionsEditor();
        }

        private void editorButton_Click(object sender, EventArgs e)
        {
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
                }
                else
                {
                    MessageBox.Show("Password Sbagliata");
                }
            }
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            this.change.ShowDialog();
            
        }
    }
}
