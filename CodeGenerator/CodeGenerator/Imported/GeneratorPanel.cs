using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CodeGenerator.Imported
{ 
    public partial class GeneratorPanel : Form
    {
        /*Builder*/
        public GeneratorPanel()
        {
            InitializeComponent();

            this.generatorButton.Enabled = true; ;            
        }

        /*Activation button action*/
        private void generatorButton_Click(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text.Length > 0)
            {
                this.codeTextBox.Text = Crypter.Encrypt(this.nameTextBox.Text);
                return;
            }
            MessageBox.Show("Inserire un nome");
        }
    }
}
