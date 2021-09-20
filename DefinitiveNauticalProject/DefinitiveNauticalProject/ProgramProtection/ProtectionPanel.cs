using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DefinitiveNauticalProject.Password;
using System.Threading;

namespace DefinitiveNauticalProject.ProgramProtection 
{ 
    public partial class ProtectionPanel : Form
    {
        /*Private fields*/
        private String json;
        private String license;
        private String user;

        /*Builder*/
        public ProtectionPanel()
        {
            InitializeComponent();

            this.activationButton.Enabled = false;
            this.user = Environment.UserName;

            if (System.IO.File.Exists("License.pw"))
            {
                this.json = File.ReadAllText("License.pw");
                this.license = JsonConvert.DeserializeObject<string>(json);

                if (this.user == Crypter.Decrypt(this.license))
                {
                    /*Loaded an anonymouse event in way to close the form into the builder*/
                    Load += (s, e) => Close();
                    return;
                }

            }
            this.nameTextBox.Text = this.user;
            this.activationButton.Enabled = true;
        }

        /*Activation button action*/
        private void activationButton_Click(object sender, EventArgs e)
        {
            if(this.codeTextBox.Text.Length>0 && Crypter.Decrypt(this.codeTextBox.Text) == this.user)
            {
                this.json = JsonConvert.SerializeObject(this.codeTextBox.Text);
                System.IO.File.WriteAllText("License.pw", json);
                MessageBox.Show("programma attivato.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Codice sbagliato");
            }
        }
        
        /*Close the entire program in case of no license*/
        private void ProtectionPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
