
namespace DefinitiveNauticalProject.Password
{
    partial class PasswordPanel
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.editorButton = new System.Windows.Forms.Button();
            this.passwordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(12, 9);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(151, 39);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(180, 9);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(515, 33);
            this.passwordTextBox.TabIndex = 1;
            // 
            // editorButton
            // 
            this.editorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.editorButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editorButton.Location = new System.Drawing.Point(180, 68);
            this.editorButton.Name = "editorButton";
            this.editorButton.Size = new System.Drawing.Size(236, 43);
            this.editorButton.TabIndex = 2;
            this.editorButton.Text = "Apri l\'Editor dei quiz";
            this.editorButton.UseVisualStyleBackColor = false;
            this.editorButton.Click += new System.EventHandler(this.editorButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordButton.Location = new System.Drawing.Point(459, 68);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(236, 43);
            this.passwordButton.TabIndex = 3;
            this.passwordButton.Text = "Modifica Password";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // PasswordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(718, 141);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.editorButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = global::DefinitiveNauticalProject.Properties.Resources.RomboQuiz;
            this.Name = "PasswordPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button editorButton;
        private System.Windows.Forms.Button passwordButton;
    }
}