using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DefinitiveNauticalProject.Questions;
using DefinitiveNauticalProject.Utility;

namespace DefinitiveNauticalProject.Editor
{
    public partial class QuestionsEditor : Form
    {
        /*Fields*/
        private bool limit; /*is used to determinate the type of quiz*/
        private bool statusPanel; /*is used to protect the phases of the program*/
        private bool saveStatus; /*is use to track the status of changes*/
        private int index; /*the index of the current list*/
        private string image; /*the string that rappresent the imge inserted*/


        /*Builder*/
        public QuestionsEditor()
        {
            InitializeComponent();
            this.index = 0;
            DisablePanel();
            this.statusPanel = false; /*first start*/
            this.saveStatus = true;

        }

        /*----------------------------------------Private methods-----------------------------*/

        /*is used to represent a index that is human readble*/
        private int graphicIndex()
        {
            return this.index +1;
        }

        /*================================Private method that enable/disable the areas of form===================*/
        private void DisablePanel()
        {
            this.nextButton.Enabled = false;
            this.prewButton.Enabled = false;
            this.correctAnswerTextBox.Enabled = false;
            this.totalQuestionTextBox.Enabled = false;
            this.SearchButton.Enabled = false;
            this.currentQuestionTextBox.Enabled = false;
            this.insertButton.Enabled = false;
            this.saveDatabaseButton.Enabled = false;
            this.pictureBox.Enabled = false;
            this.deleteImageButton.Enabled = false;
        }

        private void EnablePanel()
        {
            this.nextButton.Enabled = true;
            this.prewButton.Enabled = true;
            this.correctAnswerTextBox.Enabled = true;
            this.totalQuestionTextBox.Enabled = true;
            this.SearchButton.Enabled = true;
            this.currentQuestionTextBox.Enabled = true;
            this.insertButton.Enabled = true;
            this.saveDatabaseButton.Enabled = true;
            this.pictureBox.Enabled = true;
            this.deleteImageButton.Enabled = true;
        }

        /*============================private methods that write/delete the questions into the form=================*/
        private void FormatPanel()
        {
            this.correctAnswerTextBox.Clear();
            this.questionTextBox.Clear();
            this.answer1TextBox.Clear();
            this.answer2TextBox.Clear();
            this.answer3TextBox.Clear();
            this.pictureBox.Image = null;
            this.image = null;
        }

        private void writeQuestion()
        {

            FormatPanel();
            if (limit)
            {
                if (DatabaseQuestions.Within12miles.Count >0 && index<DatabaseQuestions.Within12miles.Count)
                {

                    this.correctAnswerTextBox.Text = DatabaseQuestions.Within12miles[index].correctAnswer.ToString();
                    this.questionTextBox.Text = DatabaseQuestions.Within12miles[index].question;
                    this.answer1TextBox.Text = DatabaseQuestions.Within12miles[index].answer1;
                    this.answer2TextBox.Text = DatabaseQuestions.Within12miles[index].answer2;
                    this.answer3TextBox.Text = DatabaseQuestions.Within12miles[index].answer3;
                    this.image = DatabaseQuestions.Within12miles[index].B64image;
                    this.pictureBox.Image = ImageUtil.GetImageFromString(this.image);

                    this.currentQuestionTextBox.Clear();
                    this.currentQuestionTextBox.Text = graphicIndex().ToString();
                    this.statusButton.BackColor = Color.Green;
                }
                else
                {

                    this.statusButton.BackColor = Color.Red;
                    this.pictureBox.Image = null;
                    this.currentQuestionTextBox.Clear();
                    this.currentQuestionTextBox.Text = graphicIndex().ToString();
                }

            }
            else
            {
                if (DatabaseQuestions.Beyond12miles.Count >0 && index < DatabaseQuestions.Beyond12miles.Count)
                {

                    this.correctAnswerTextBox.Text = DatabaseQuestions.Beyond12miles[index].correctAnswer.ToString();
                    this.questionTextBox.Text = DatabaseQuestions.Beyond12miles[index].question;
                    this.answer1TextBox.Text = DatabaseQuestions.Beyond12miles[index].answer1;
                    this.answer2TextBox.Text = DatabaseQuestions.Beyond12miles[index].answer2;
                    this.answer3TextBox.Text = DatabaseQuestions.Beyond12miles[index].answer3;
                    

                    if (DatabaseQuestions.Beyond12miles[index].B64image != null)
                    {
                        this.pictureBox.Image = ImageUtil.GetImageFromString(DatabaseQuestions.Beyond12miles[index].B64image);
                    }
                    this.currentQuestionTextBox.Clear();
                    this.currentQuestionTextBox.Text = graphicIndex().ToString();
                    this.statusButton.BackColor = Color.Green;
                }
                else
                {
                    this.currentQuestionTextBox.Clear();
                    this.pictureBox.Image = null;
                    this.currentQuestionTextBox.Text = graphicIndex().ToString();
                    this.statusButton.BackColor = Color.Red;
                }
            }
        }

        /*=======================================Private method of control the danger things====================*/
        private void LimitCounter()
        {
            if (this.limit)
            {
                if (graphicIndex() == 1)
                {
                    this.prewButton.Enabled = false;
                    this.nextButton.Enabled = true;
                }
                else
                {
                    if (graphicIndex() == Constants.Within12Limit)
                    {
                        this.prewButton.Enabled = true;
                        this.nextButton.Enabled = false;
                    }
                    else
                    {
                        this.prewButton.Enabled = true;
                        this.nextButton.Enabled = true;
                    }
                }
            }
            else
            {
                if (graphicIndex() == 1)
                {
                    this.prewButton.Enabled = false;
                    this.nextButton.Enabled = true;
                }
                else
                {
                    if (graphicIndex() == Constants.Beyond12Limit)
                    {
                        this.prewButton.Enabled = true;
                        this.nextButton.Enabled = false;
                    }
                    else
                    {
                        this.prewButton.Enabled = true;
                        this.nextButton.Enabled = true;
                    }
                }
            }
        }

        /*control if the string is composed by only numbers*/
        private bool StringNumberControl(string s)
        {
            return Regex.IsMatch(s, @"^\d+$");
        }

        private bool ControlInsert()
        {
            /*Correct (number) answer constrols*/

            if (StringNumberControl(this.correctAnswerTextBox.Text))
            {
                if (this.correctAnswerTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("Non tutti i campi sono stati riempiti");
                    return false;
                }

                if (Int32.Parse(this.correctAnswerTextBox.Text) <= 0 || Int32.Parse(this.correctAnswerTextBox.Text) > 3)
                {
                    MessageBox.Show("Il numero della risposta corretta non è valido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Il parametro di risposta giusta non è valido");
                return false;
            }

            /*Other controls*/
            if (this.questionTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Non tutti i campi sono stati riempiti");
                return false;
            }

            if (this.answer1TextBox.Text.Length <= 0)
            {
                MessageBox.Show("Non tutti i campi sono stati riempiti");
                return false;
            }

            if (this.answer2TextBox.Text.Length <= 0)
            {
                MessageBox.Show("Non tutti i campi sono stati riempiti");
                return false;
            }

            if (this.answer3TextBox.Text.Length <= 0)
            {
                MessageBox.Show("Non tutti i campi sono stati riempiti");
                return false;
            }



            return true;
        }

        /*-----------------------------------GUI methods*/

        private void within12Button_Click(object sender, EventArgs e)
        {
            this.within12Button.Enabled = false;
            this.beyond12Button.Enabled = true;
            this.within12Button.BackColor = Color.DarkGreen;
            this.beyond12Button.BackColor = Color.LightGray;
            this.limit = true;
            this.totalQuestionTextBox.Clear();
            this.totalQuestionTextBox.Text = Constants.Within12Limit.ToString();

            if (!this.statusPanel)
            {
                EnablePanel();
                this.statusPanel = true;
            }

            LimitCounter();
            writeQuestion();
        }

        private void beyond12Button_Click(object sender, EventArgs e)
        {
            this.within12Button.Enabled = true;
            this.beyond12Button.Enabled = false;
            this.within12Button.BackColor = Color.LightGray;
            this.beyond12Button.BackColor = Color.DarkGreen;
            this.limit = false;
            this.totalQuestionTextBox.Clear();
            this.totalQuestionTextBox.Text = Constants.Beyond12Limit.ToString();

            if (!this.statusPanel)
            {
                EnablePanel();
                this.statusPanel = true;
            }

            LimitCounter();
            writeQuestion();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int localIndex;

            if (StringNumberControl(this.currentQuestionTextBox.Text))
            {
                localIndex = Int32.Parse(this.currentQuestionTextBox.Text);
            }
            else
            {
                MessageBox.Show("Il termine di ricerca non è valido");
                return;
            }
            

            if (limit)
            {
                if(localIndex >=1 && localIndex<=Constants.Within12Limit && DatabaseQuestions.Within12miles.Count >= localIndex )
                {
                    this.index = localIndex - 1;
                    writeQuestion();
                    LimitCounter();
                }
                else
                {
                    MessageBox.Show("Il quiz cercato non esiste");
                    this.currentQuestionTextBox.Text = graphicIndex().ToString();
                }
            }
            else
            {
                if (localIndex >= 1 && localIndex <= Constants.Beyond12Limit && DatabaseQuestions.Beyond12miles.Count >= localIndex)
                {
                    this.index = localIndex - 1;
                    writeQuestion();
                    LimitCounter();
                }
                else
                {
                    MessageBox.Show("Il quiz cercato non esiste");
                    this.currentQuestionTextBox.Text = graphicIndex().ToString();
                }
            }
        }

        private void prewButton_Click(object sender, EventArgs e)
        {
            if(graphicIndex() >= 1)
            {
                index--;
            }
            LimitCounter();
            writeQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (limit)
            {
                if(graphicIndex() <= Constants.Within12Limit)
                {
                    index++;
                }
            }
            else
            {
                if (graphicIndex() <= Constants.Beyond12Limit)
                {
                    index++;
                }
            }

            LimitCounter();
            writeQuestion();
        }

        

        private void saveDatabaseButton_Click(object sender, EventArgs e)
        {
            this.saveStatus = true;
            if (DatabaseQuestions.SaveDatabase(this.limit))
            {
                MessageBox.Show("Domande salvate con successo");
            }
            else
            {
                MessageBox.Show("Domande non salvate");
            }
        }

        /*+++++++++++++++++++++++++++++++++++++++++++ Area dedicated to the picture box++++++++++++++++++++++++++++++*/

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var temp = data as string[];
                this.image = ImageUtil.ConvertImageToString(temp[0]);

                if (image.Length > 0)
                {
                    this.pictureBox.Image = ImageUtil.GetImageFromString(this.image);
                }

            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void QuestionsEditor_Load(object sender, EventArgs e)
        {
            pictureBox.AllowDrop = true;
        }
        /*++++++++++++++++++++++++++++++++++++++++End of the dedicated Area+++++++++++++++++++++++++++++++++++++++*/

        /*================================================== Last method usefull to save the database/seave the question into*/
        private void insertButton_Click(object sender, EventArgs e)
        {
            /*this control is usefull to protect the insert of the questions from a different index*/
            if (graphicIndex() != Int32.Parse(this.currentQuestionTextBox.Text))
            {
                MessageBox.Show("L`indice della domanda corrente non è corretto");
                return;
            }

            Question temp;

            if (ControlInsert())
            {
                this.saveStatus = false;

                if (this.image != null)
                {
                    try
                    {
                        temp = new Question(graphicIndex(), this.questionTextBox.Text, this.answer1TextBox.Text, this.answer2TextBox.Text, this.answer3TextBox.Text, Int32.Parse(this.correctAnswerTextBox.Text), image);
                    }
                    catch(ArgumentOutOfRangeException error)
                    {
                        MessageBox.Show(error.Message);
                        return;
                    }
                    

                }
                else
                {
                    try
                    {
                        temp = new Question(graphicIndex(), this.questionTextBox.Text, this.answer1TextBox.Text, this.answer2TextBox.Text, this.answer3TextBox.Text, Int32.Parse(this.correctAnswerTextBox.Text), null);
                    }
                    catch (ArgumentOutOfRangeException error)
                    {
                        MessageBox.Show(error.Message);
                        return;
                    }

                }

                if (limit)
                {
                    if(this.index >= DatabaseQuestions.Within12miles.Count)
                    {
                        DatabaseQuestions.Within12miles.Add(temp);
                    }
                    else
                    {
                        DatabaseQuestions.Within12miles.RemoveAt(index);
                        DatabaseQuestions.Within12miles.Insert(index, temp);
                        MessageBox.Show("La domanda è stata modificata");
                    }
                    
                }
                else
                {
                    if(this.index>= DatabaseQuestions.Beyond12miles.Count)
                    {
                        DatabaseQuestions.Beyond12miles.Add(temp);
                    }
                    else
                    {
                        DatabaseQuestions.Beyond12miles.RemoveAt(index);
                        DatabaseQuestions.Beyond12miles.Insert(index, temp);
                        MessageBox.Show("La domanda è stata modificata");

                    }
                    
                }

                writeQuestion();
            }
           
        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = null;
            this.image = null;
        }

        private void QuestionsEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.saveStatus)
            {
                if (DatabaseQuestions.SaveDatabase(this.limit))
                {
                    MessageBox.Show("Domande salvate con successo");
                }
                else
                {
                    MessageBox.Show("Domande non salvate");
                }
            }
        }
    }
}
