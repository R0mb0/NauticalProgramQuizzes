namespace DefinitiveNauticalProject.Editor
{
    partial class QuestionsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsEditor));
            this.EditorQuizLabel = new System.Windows.Forms.Label();
            this.utilityPanel = new System.Windows.Forms.Panel();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.quizStatusLabel = new System.Windows.Forms.Label();
            this.questionCounterLabel = new System.Windows.Forms.Label();
            this.SeparationLabel = new System.Windows.Forms.Label();
            this.currentQuestionTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.totalQuestionTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerTextBox = new System.Windows.Forms.TextBox();
            this.prewButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.beyond12Button = new System.Windows.Forms.Button();
            this.within12Button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.answer3TextBox = new System.Windows.Forms.TextBox();
            this.answer2TextBox = new System.Windows.Forms.TextBox();
            this.answer1TextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answer1Label = new System.Windows.Forms.Label();
            this.answer2Label = new System.Windows.Forms.Label();
            this.answer3Label = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.saveDatabaseButton = new System.Windows.Forms.Button();
            this.utilityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorQuizLabel
            // 
            this.EditorQuizLabel.AutoSize = true;
            this.EditorQuizLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditorQuizLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EditorQuizLabel.Location = new System.Drawing.Point(618, 25);
            this.EditorQuizLabel.Name = "EditorQuizLabel";
            this.EditorQuizLabel.Size = new System.Drawing.Size(327, 45);
            this.EditorQuizLabel.TabIndex = 0;
            this.EditorQuizLabel.Text = "EDITOR DEI QUIZ";
            // 
            // utilityPanel
            // 
            this.utilityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.utilityPanel.Controls.Add(this.deleteImageButton);
            this.utilityPanel.Controls.Add(this.statusButton);
            this.utilityPanel.Controls.Add(this.SearchButton);
            this.utilityPanel.Controls.Add(this.quizStatusLabel);
            this.utilityPanel.Controls.Add(this.questionCounterLabel);
            this.utilityPanel.Controls.Add(this.SeparationLabel);
            this.utilityPanel.Controls.Add(this.currentQuestionTextBox);
            this.utilityPanel.Controls.Add(this.correctAnswerLabel);
            this.utilityPanel.Controls.Add(this.totalQuestionTextBox);
            this.utilityPanel.Controls.Add(this.correctAnswerTextBox);
            this.utilityPanel.Controls.Add(this.prewButton);
            this.utilityPanel.Controls.Add(this.nextButton);
            this.utilityPanel.Controls.Add(this.beyond12Button);
            this.utilityPanel.Controls.Add(this.within12Button);
            this.utilityPanel.Location = new System.Drawing.Point(45, 115);
            this.utilityPanel.Name = "utilityPanel";
            this.utilityPanel.Size = new System.Drawing.Size(1560, 179);
            this.utilityPanel.TabIndex = 1;
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteImageButton.Location = new System.Drawing.Point(756, 113);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(190, 41);
            this.deleteImageButton.TabIndex = 7;
            this.deleteImageButton.Text = "Cancella immagine";
            this.deleteImageButton.UseVisualStyleBackColor = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // statusButton
            // 
            this.statusButton.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusButton.Location = new System.Drawing.Point(337, 21);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(54, 54);
            this.statusButton.TabIndex = 0;
            this.statusButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(985, 112);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(172, 41);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Cerca Domanda";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // quizStatusLabel
            // 
            this.quizStatusLabel.AutoSize = true;
            this.quizStatusLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quizStatusLabel.Location = new System.Drawing.Point(134, 30);
            this.quizStatusLabel.Name = "quizStatusLabel";
            this.quizStatusLabel.Size = new System.Drawing.Size(197, 35);
            this.quizStatusLabel.TabIndex = 0;
            this.quizStatusLabel.Text = "Stato del Quiz:";
            // 
            // questionCounterLabel
            // 
            this.questionCounterLabel.AutoSize = true;
            this.questionCounterLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionCounterLabel.Location = new System.Drawing.Point(1030, 30);
            this.questionCounterLabel.Name = "questionCounterLabel";
            this.questionCounterLabel.Size = new System.Drawing.Size(127, 35);
            this.questionCounterLabel.TabIndex = 0;
            this.questionCounterLabel.Text = "Domande:";
            // 
            // SeparationLabel
            // 
            this.SeparationLabel.AutoSize = true;
            this.SeparationLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SeparationLabel.Location = new System.Drawing.Point(1229, 74);
            this.SeparationLabel.Name = "SeparationLabel";
            this.SeparationLabel.Size = new System.Drawing.Size(27, 35);
            this.SeparationLabel.TabIndex = 0;
            this.SeparationLabel.Text = "/";
            // 
            // currentQuestionTextBox
            // 
            this.currentQuestionTextBox.Location = new System.Drawing.Point(1188, 112);
            this.currentQuestionTextBox.Name = "currentQuestionTextBox";
            this.currentQuestionTextBox.Size = new System.Drawing.Size(104, 41);
            this.currentQuestionTextBox.TabIndex = 0;
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.AutoSize = true;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.correctAnswerLabel.Location = new System.Drawing.Point(548, 63);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(202, 35);
            this.correctAnswerLabel.TabIndex = 0;
            this.correctAnswerLabel.Text = "Risposta Giusta:";
            // 
            // totalQuestionTextBox
            // 
            this.totalQuestionTextBox.Location = new System.Drawing.Point(1188, 30);
            this.totalQuestionTextBox.Name = "totalQuestionTextBox";
            this.totalQuestionTextBox.ReadOnly = true;
            this.totalQuestionTextBox.Size = new System.Drawing.Size(104, 41);
            this.totalQuestionTextBox.TabIndex = 0;
            // 
            // correctAnswerTextBox
            // 
            this.correctAnswerTextBox.Location = new System.Drawing.Point(575, 113);
            this.correctAnswerTextBox.Name = "correctAnswerTextBox";
            this.correctAnswerTextBox.Size = new System.Drawing.Size(150, 41);
            this.correctAnswerTextBox.TabIndex = 0;
            // 
            // prewButton
            // 
            this.prewButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prewButton.Location = new System.Drawing.Point(88, 92);
            this.prewButton.Name = "prewButton";
            this.prewButton.Size = new System.Drawing.Size(172, 62);
            this.prewButton.TabIndex = 5;
            this.prewButton.Text = "Domanda Precedente";
            this.prewButton.UseVisualStyleBackColor = true;
            this.prewButton.Click += new System.EventHandler(this.prewButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(289, 92);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(172, 62);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Domanda Successiva";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // beyond12Button
            // 
            this.beyond12Button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.beyond12Button.Location = new System.Drawing.Point(1357, 101);
            this.beyond12Button.Name = "beyond12Button";
            this.beyond12Button.Size = new System.Drawing.Size(172, 53);
            this.beyond12Button.TabIndex = 2;
            this.beyond12Button.Text = "Oltre 12 Miglia";
            this.beyond12Button.UseVisualStyleBackColor = true;
            this.beyond12Button.Click += new System.EventHandler(this.beyond12Button_Click);
            // 
            // within12Button
            // 
            this.within12Button.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.within12Button.Location = new System.Drawing.Point(1357, 18);
            this.within12Button.Name = "within12Button";
            this.within12Button.Size = new System.Drawing.Size(172, 53);
            this.within12Button.TabIndex = 1;
            this.within12Button.Text = "Entro 12 Miglia";
            this.within12Button.UseVisualStyleBackColor = true;
            this.within12Button.Click += new System.EventHandler(this.within12Button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox.Location = new System.Drawing.Point(1157, 327);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(453, 392);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.answer3TextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer3TextBox.Location = new System.Drawing.Point(133, 749);
            this.answer3TextBox.Multiline = true;
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer3TextBox.Size = new System.Drawing.Size(973, 87);
            this.answer3TextBox.TabIndex = 0;
            // 
            // answer2TextBox
            // 
            this.answer2TextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.answer2TextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer2TextBox.Location = new System.Drawing.Point(133, 632);
            this.answer2TextBox.Multiline = true;
            this.answer2TextBox.Name = "answer2TextBox";
            this.answer2TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer2TextBox.Size = new System.Drawing.Size(973, 87);
            this.answer2TextBox.TabIndex = 0;
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.answer1TextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer1TextBox.Location = new System.Drawing.Point(133, 516);
            this.answer1TextBox.Multiline = true;
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answer1TextBox.Size = new System.Drawing.Size(973, 87);
            this.answer1TextBox.TabIndex = 0;
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.questionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionTextBox.Location = new System.Drawing.Point(133, 327);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionTextBox.Size = new System.Drawing.Size(973, 157);
            this.questionTextBox.TabIndex = 0;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(6, 387);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(117, 25);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "DOMANDA:";
            // 
            // answer1Label
            // 
            this.answer1Label.AutoSize = true;
            this.answer1Label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer1Label.Location = new System.Drawing.Point(10, 549);
            this.answer1Label.Name = "answer1Label";
            this.answer1Label.Size = new System.Drawing.Size(119, 25);
            this.answer1Label.TabIndex = 3;
            this.answer1Label.Text = "RISPOSTA1";
            // 
            // answer2Label
            // 
            this.answer2Label.AutoSize = true;
            this.answer2Label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer2Label.Location = new System.Drawing.Point(10, 666);
            this.answer2Label.Name = "answer2Label";
            this.answer2Label.Size = new System.Drawing.Size(119, 25);
            this.answer2Label.TabIndex = 3;
            this.answer2Label.Text = "RISPOSTA2";
            // 
            // answer3Label
            // 
            this.answer3Label.AutoSize = true;
            this.answer3Label.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer3Label.Location = new System.Drawing.Point(4, 777);
            this.answer3Label.Name = "answer3Label";
            this.answer3Label.Size = new System.Drawing.Size(119, 25);
            this.answer3Label.TabIndex = 3;
            this.answer3Label.Text = "RISPOSTA3";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(1199, 749);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(138, 119);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "Inserisci/Salva Quiz";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // saveDatabaseButton
            // 
            this.saveDatabaseButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveDatabaseButton.Location = new System.Drawing.Point(1436, 749);
            this.saveDatabaseButton.Name = "saveDatabaseButton";
            this.saveDatabaseButton.Size = new System.Drawing.Size(138, 119);
            this.saveDatabaseButton.TabIndex = 5;
            this.saveDatabaseButton.Text = "Salva\r\nDatabase";
            this.saveDatabaseButton.UseVisualStyleBackColor = true;
            this.saveDatabaseButton.Click += new System.EventHandler(this.saveDatabaseButton_Click);
            // 
            // QuestionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1658, 918);
            this.Controls.Add(this.saveDatabaseButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.answer3Label);
            this.Controls.Add(this.answer2Label);
            this.Controls.Add(this.answer1Label);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answer1TextBox);
            this.Controls.Add(this.utilityPanel);
            this.Controls.Add(this.answer2TextBox);
            this.Controls.Add(this.EditorQuizLabel);
            this.Controls.Add(this.answer3TextBox);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = Properties.Resources.RomboQuiz;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionsEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionsEditor_FormClosing);
            this.Load += new System.EventHandler(this.QuestionsEditor_Load);
            this.utilityPanel.ResumeLayout(false);
            this.utilityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditorQuizLabel;
        private System.Windows.Forms.Panel utilityPanel;
        private System.Windows.Forms.Button beyond12Button;
        private System.Windows.Forms.Button within12Button;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox answer3TextBox;
        private System.Windows.Forms.TextBox answer2TextBox;
        private System.Windows.Forms.TextBox answer1TextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answer1Label;
        private System.Windows.Forms.Label answer2Label;
        private System.Windows.Forms.Label answer3Label;
        private System.Windows.Forms.Button prewButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label questionCounterLabel;
        private System.Windows.Forms.Label SeparationLabel;
        private System.Windows.Forms.TextBox currentQuestionTextBox;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.TextBox totalQuestionTextBox;
        private System.Windows.Forms.TextBox correctAnswerTextBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Label quizStatusLabel;
        private System.Windows.Forms.Button saveDatabaseButton;
        private System.Windows.Forms.Button deleteImageButton;
    }
}