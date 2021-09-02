
namespace DefinitiveNauticalProject
{
    partial class FirstPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simulationButton = new System.Windows.Forms.Button();
            this.quizButton = new System.Windows.Forms.Button();
            this.editorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simulationButton
            // 
            this.simulationButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulationButton.ForeColor = System.Drawing.Color.Maroon;
            this.simulationButton.Location = new System.Drawing.Point(12, 12);
            this.simulationButton.Name = "simulationButton";
            this.simulationButton.Size = new System.Drawing.Size(671, 94);
            this.simulationButton.TabIndex = 0;
            this.simulationButton.Text = "SIMULAZIONE COMPITO D\'ESAME";
            this.simulationButton.UseVisualStyleBackColor = true;
            this.simulationButton.Click += new System.EventHandler(this.simulationButton_Click);
            // 
            // quizButton
            // 
            this.quizButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quizButton.ForeColor = System.Drawing.Color.Maroon;
            this.quizButton.Location = new System.Drawing.Point(12, 112);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(671, 94);
            this.quizButton.TabIndex = 1;
            this.quizButton.Text = "ESERCITAZIONE QUIZ D\'ESAME";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.quizButton_Click);
            // 
            // editorButton
            // 
            this.editorButton.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editorButton.ForeColor = System.Drawing.Color.Maroon;
            this.editorButton.Location = new System.Drawing.Point(12, 212);
            this.editorButton.Name = "editorButton";
            this.editorButton.Size = new System.Drawing.Size(671, 94);
            this.editorButton.TabIndex = 2;
            this.editorButton.Text = "MODIFICA I QUIZ";
            this.editorButton.UseVisualStyleBackColor = true;
            this.editorButton.Click += new System.EventHandler(this.editorButton_Click);
            // 
            // FirstPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(695, 324);
            this.Controls.Add(this.editorButton);
            this.Controls.Add(this.quizButton);
            this.Controls.Add(this.simulationButton);
            this.Icon = global::DefinitiveNauticalProject.Properties.Resources.RomboQuiz;
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "FirstPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Patente Nautica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simulationButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button editorButton;
    }
}

