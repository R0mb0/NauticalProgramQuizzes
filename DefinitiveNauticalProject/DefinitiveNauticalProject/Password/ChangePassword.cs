using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DefinitiveNauticalProject.Password
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            String json;
            string password;
            json = File.ReadAllText("Password.pw");
            password = JsonConvert.DeserializeObject<string>(json);

            if(this.newPasswordTextBox.Text != this.ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("La Password Di Conferma Non Corrisponde");
            }

            if (this.oldPasswordTextBox.Text == Crypter.Decrypt(password))
            {
                password = Crypter.Encrypt(this.newPasswordTextBox.Text);
                json = JsonConvert.SerializeObject(password);
                System.IO.File.WriteAllText("Password.pw", json);

                json = File.ReadAllText("Password.pw");
                password = JsonConvert.DeserializeObject<string>(json);

                this.newPasswordTextBox.Clear();
                this.oldPasswordTextBox.Clear();

                if (this.newPasswordTextBox.Text == Crypter.Decrypt(password))
                {
                    MessageBox.Show("Password Cambiata Con Successo");
                    return;
                }

                MessageBox.Show("Errore Nel Cambio Della Pasword");
            }
            else
            {
                MessageBox.Show("La Vecchia Password è Sbagliata");
            }
        }
    }
}
