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
        /*Builder*/
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            String json;
            string password;
            /*Get old password*/
            if (System.IO.File.Exists("Password.pw"))
            {
                json = File.ReadAllText("Password.pw");
                password = JsonConvert.DeserializeObject<string>(json);
            }
            else
            {
                MessageBox.Show("Non trovaato il file password, accesso negato.");
                return;
            }
            

            /*Paasssword control*/
            if(this.newPasswordTextBox.Text != this.ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("La Password Di Conferma Non Corrisponde");
                return;
            }

            if (this.oldPasswordTextBox.Text == Crypter.Decrypt(password))
            {
                /*Change password*/
                password = Crypter.Encrypt(this.newPasswordTextBox.Text);
                json = JsonConvert.SerializeObject(password);
                System.IO.File.WriteAllText("Password.pw", json);

                json = File.ReadAllText("Password.pw");
                password = JsonConvert.DeserializeObject<string>(json);

                /*reset the panel*/
                this.newPasswordTextBox.Clear();
                this.oldPasswordTextBox.Clear();

                /*control the new saved password*/
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
                return;
            }
        }
    }
}
