using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DefinitiveNauticalProject.Questions;
using DefinitiveNauticalProject.Editor;
using DefinitiveNauticalProject.Utility;
using System.Text.RegularExpressions;

namespace DefinitiveNauticalProject
{
    public partial class SimulationPanel : Form
    {
        /*Fields*/
        private bool limit; /*used to determinate the type of the quiz*/
        private bool programStatus; /*used to protect the phases of the program*/
        private bool won = false; /* monitoring the status of the wuiz*/
        private bool loose = false;
        private bool searchStatus;
        private int correctAnswerCounter = 0; /* used to counter the answers given*/
        private int wrongAnswerCounter = 0;/* used to counter the wrong answers given*/
        private int answerGivenCountuer = 0;/* used to counter cprrect the answers given*/
        /*list*/
        private QuestionManager questionManager;
        /*Prepare the second form to be opened*/
         QuestionsEditor editor;

        /*-----------------------------------------------------------------------------------------*/

        /*BUILDER*/
        public SimulationPanel()
        {
            InitializeComponent();
            DisableActionButtons();
            DisableNavigationButtons();
            DisabelSearch();
            this.WonButton.Enabled = false; /*this is the light the comunicate if the simulation is passed*/

            this.editor = new QuestionsEditor();
        }

        /*--------------------------------------PRIVATE FUNCTIONALITY METHOD---------------------------------------------------*/
        /*is used to represent a index that is human readble*/
        private int GraphicIndex()
        {
            return this.questionManager.GetIndex() + 1;
        }

        /*======================================== Private methods that enabled the panel===========================*/
        private void ResetQuestion()
        {
            this.questionBox.Clear();
            this.answerBox1.Clear();
            this.answerBox2.Clear();
            this.answerBox3.Clear();
            this.questionNumberBox.Clear();
            /*image box reset*/
            this.imageBox.Image = null;
            /*button reset*/
            ResetButtons();
            
        }

        private void ResetButtons()
        {
            this.answerButton1.BackColor = Color.LightGray;
            this.answerButton1.Text = " ";
            this.answerButton2.BackColor = Color.LightGray;
            this.answerButton2.Text = " ";
            this.answerButton3.BackColor = Color.LightGray;
            this.answerButton3.Text = " ";
        }

        private void DisabelSearch()
        {
            this.searchQuestionButton.Enabled = false;
            this.searchQuestionTextBox.Clear();
            this.searchQuestionTextBox.Enabled = false;
        }

        private void DisableNavigationButtons()
        {
            this.prewButton.Enabled = false;
            this.nextButton.Enabled = false;
        }

        private void DisableLimitButtons()
        {
            this.within12Button.Enabled = false;
            this.beyond12Button.Enabled = false;
        }

        private void DisableQuestionButtons()
        {
            this.answerButton1.Enabled = false;
            this.answerButton2.Enabled = false;
            this.answerButton3.Enabled = false;
        }

        private void DisableActionButtons()
        {
            this.startbutton.Enabled = false;
            this.stopButton.Enabled = false;
            this.programStatus = false;
        }

        private void EnableNavigationButtons()
        {
            this.prewButton.Enabled = true;
            this.nextButton.Enabled = true;
        }

        private void EnableLimitButtons()
        {
            this.within12Button.Enabled = true;
            this.beyond12Button.Enabled = true;
        }

        private void EnableQuestionButtons()
        {
            this.answerButton1.Enabled = true;
            this.answerButton2.Enabled = true;
            this.answerButton3.Enabled = true;
        }

        private void EnableActionButtons()
        {
            this.startbutton.Enabled = true;
            this.stopButton.Enabled = true;
            this.programStatus = true;
        }

        private void EnableSearch()
        {
            this.searchQuestionButton.Enabled = true;
            this.searchQuestionTextBox.Enabled = true;
        }
        /*============================================== Private methods that delete/write the quiz ===================*/

        /*this update the point value of the panel*/
        private void UpdatePanel()
        {
            this.correctAnswerBox.Text = this.correctAnswerCounter.ToString();
            this.wrongAnswerBox.Text = this.wrongAnswerCounter.ToString();
            this.CurrentQuestionBox.Text = (GraphicIndex()).ToString();
        }

        /*Write questions*/
        private void WriteQuestions()
        {
            if (this.questionManager.GetQuestion() is null)
            {
                return;
            }

            this.questionBox.Text = this.questionManager.GetQuestion().question;
            this.questionNumberBox.Text = "Numero Quiz:\n" + questionManager.GetQuestion().questionNumber.ToString();
            this.answerBox1.Text = this.questionManager.GetQuestion().answer1;
            this.answerBox2.Text = this.questionManager.GetQuestion().answer2;
            this.answerBox3.Text = this.questionManager.GetQuestion().answer3;
            this.imageBox.Image = ImageUtil.GetImageFromString(questionManager.GetQuestion().B64image);
            
        }

       /*this method is usefull to see the status of the answer given, it permit to see the result, but is impossible change it*/
        private void GlobalPaint()
        {
            if (this.questionManager.GetQuestion().answerGiven != 0)
            {
                switch (this.questionManager.GetQuestion().correctAnswer)
                {

                    case 1:
                        this.answerButton1.BackColor = Color.Green;
                        this.answerButton2.BackColor = Color.Red;
                        this.answerButton3.BackColor = Color.Red;
                        break;

                    case 2:
                        this.answerButton1.BackColor = Color.Red;
                        this.answerButton2.BackColor = Color.Green;
                        this.answerButton3.BackColor = Color.Red;
                        break;

                    case 3:
                        this.answerButton1.BackColor = Color.Red;
                        this.answerButton2.BackColor = Color.Red;
                        this.answerButton3.BackColor = Color.Green;
                        break;

                    default:
                        MessageBox.Show("Error from correctAnswer Paint");
                        break;
                }

                switch (this.questionManager.GetQuestion().answerGiven)
                {
                    case 0:
                        break;

                    case 1:
                        this.answerButton1.Text = "X";
                        break;

                    case 2:
                        this.answerButton2.Text = "X";
                        break;

                    case 3:
                        this.answerButton3.Text = "X";

                        break;

                    default:
                        MessageBox.Show("Error from answerGiven Paint");
                        break;
                }
            }
            
        }

        /*========================================================Private methods that provide to the correct funzionality of simulation*/

        /*this method provide to disabel the correct button*/
        private void LimitCounter()
        {
            if (this.questionManager.ControlPosiction() == MagicNumbers.oneElement)
            {
                DisableNavigationButtons();
            }

            if (this.questionManager.ControlPosiction() == MagicNumbers.tail)
            {
                this.prewButton.Enabled = false;
                this.nextButton.Enabled = true;
            }

            if (this.questionManager.ControlPosiction() == MagicNumbers.center)
            {
                EnableNavigationButtons();
            }

            if (this.questionManager.ControlPosiction() == MagicNumbers.head)
            {
                this.prewButton.Enabled = true;
                this.nextButton.Enabled = false;
            }
 
        }

        private void WinCondiction()
        {
            if (this.searchStatus)
            {
                return;
            }

            if (this.limit)
            {
                if (this.wrongAnswerCounter > Constants.Within12ErrorLimit)
                {
                    MessageBox.Show("Hai fallito la prova per troppi errori");
                    this.loose = true;
                    this.WonButton.BackColor = Color.Red;
                }
                else
                {
                    if (this.answerGivenCountuer == Constants.Within12QuestionsLimit )
                    {
                        MessageBox.Show("Hai superato la prova ");
                        this.won = true;
                        this.WonButton.BackColor = Color.Green;
                    }
                    
                }
            }
            else
            {
                if (this.wrongAnswerCounter > Constants.Beyond12ErrorLimit)
                {
                    MessageBox.Show("Hai fallito la prova per troppi errori");
                    this.loose = true;
                    this.WonButton.BackColor = Color.Red;
                }
                else
                {
                    if (this.answerGivenCountuer  == Constants.Beyond12QuestionsLimit)
                    {
                        MessageBox.Show("Hai superato la prova ");
                        this.won = true;
                        this.WonButton.BackColor = Color.Green;
                    }
                    
                }
            }
        }

        /*-----------------------------------GUI BUTTON-------------------------------------------------------------*/

        /*Within 12 miles Method*/
        private void within12Button_Click(object sender, EventArgs e)
        {
            this.limit = true;
            this.questionManager = new QuestionManager(this.limit);
            this.totalQuestionsBox.Clear();
            EnableSearch();
            EnableActionButtons();
            this.within12Button.BackColor = Color.DarkGreen;
            this.beyond12Button.BackColor = Color.LightGray;
        }

        /*Beyond 12 miles Method*/
        private void beyond12Button_Click(object sender, EventArgs e)
        {
            this.limit = false;
            this.questionManager = new QuestionManager(this.limit);
            this.totalQuestionsBox.Clear();
            EnableSearch();
            EnableActionButtons();
            this.within12Button.BackColor = Color.LightGray;
            this.beyond12Button.BackColor = Color.DarkGreen;
        }

        /*===========================================================================================*/
        /*Stop Method, reset of the component method*/
        private void stopButton_Click(object sender, EventArgs e)
        {
            this.startbutton.Enabled = true;
            ResetQuestion();
            this.questionManager = null;
            EnableLimitButtons();

            /*textbox reset*/
            this.CurrentQuestionBox.Clear();
            this.totalQuestionsBox.Clear();
            this.correctAnswerBox.Clear();
            this.wrongAnswerBox.Clear();
            
            /*Button reset*/
            this.startbutton.BackColor = Color.LightGray;
            this.within12Button.BackColor = Color.LightGray;
            this.beyond12Button.BackColor = Color.LightGray;
            this.WonButton.BackColor= Color.LightGray;

            this.correctAnswerCounter = 0;
            this.wrongAnswerCounter = 0;
            this.answerGivenCountuer = 0;
            this.won = false;
            this.loose = false;
            this.searchStatus = false;

            DisableActionButtons();
            DisableNavigationButtons();
            DisabelSearch();
        }


        /*Start button refernce*/
        private void startbutton_Click(object sender, EventArgs e)
        {
            DisableLimitButtons();
            DisabelSearch();
            this.startbutton.Enabled = false;

            if (this.searchStatus)
            {
                this.searchStatus = false;
            }

            if (this.limit)
            {
                this.totalQuestionsBox.Text = Constants.Within12QuestionsLimit.ToString();
            }
            else
            {
                this.totalQuestionsBox.Text = Constants.Beyond12QuestionsLimit.ToString();
            }

            if (this.programStatus)
            {
                    questionManager.AskQuestionList();
                    this.startbutton.BackColor = Color.MediumVioletRed;
                    EnableQuestionButtons();
                    LimitCounter();
                    WriteQuestions();
                    UpdatePanel(); 
            }
            else
            {
                MessageBox.Show("Error from the status");
            }
               
        }

        /*=======================================================================================================*/

        /*Prew Button*/
        private void prewButton_Click(object sender, EventArgs e)
        {
            
            EnableQuestionButtons();

            if (!questionManager.IndexDecrement())
            {
                MessageBox.Show("Error to the decrement");
            }

            if (this.questionManager.GetQuestion().answerGiven != 0)
            {
                DisableQuestionButtons();
            }

            ResetButtons();
            GlobalPaint();
            WriteQuestions();
            UpdatePanel();
            LimitCounter();


        }

        /*Next nutton*/
        private void nextButton_Click(object sender, EventArgs e)
        {
            ResetButtons();
            EnableQuestionButtons();

            if (!this.questionManager.IndexIncrement())
            {
                MessageBox.Show("Error from the increment");
            }

            if (this.questionManager.GetQuestion().answerGiven != 0)
            {
                DisableQuestionButtons();
                GlobalPaint();
            }

            WriteQuestions();
            UpdatePanel();
            LimitCounter();
        }

        /*++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/

        /*Answer Button 1*/
        private void answerButton1_Click(object sender, EventArgs e)
        {
            this.answerButton1.Text = "X";

            switch (this.questionManager.GetQuestion().correctAnswer)
            {
                case 1:
                    this.correctAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Green;
                    this.answerButton2.BackColor = Color.Red;
                    this.answerButton3.BackColor = Color.Red;
                    break;

                case 2:
                    this.wrongAnswerCounter ++;
                    this.answerButton1.BackColor = Color.Red;
                    this.answerButton2.BackColor = Color.Green;
                    this.answerButton3.BackColor = Color.Red;
                    break;

                case 3:
                    this.wrongAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Red;
                    this.answerButton2.BackColor = Color.Red;
                    this.answerButton3.BackColor = Color.Green;
                    break;

                default:
                    MessageBox.Show("Error from correctAnswer button 1");
                    break;
            }
            UpdatePanel();
            DisableQuestionButtons();
            if (!won && !loose)
            {
                this.answerGivenCountuer++;
                WinCondiction();
            }

            this.questionManager.GetQuestion().answerGiven = 1;
        }
        /*Answer Button 2*/
        private void answerButton2_Click(object sender, EventArgs e)
        {
            this.answerButton2.Text = "X";

            switch (this.questionManager.GetQuestion().correctAnswer)
            {
                case 1:
                    this.wrongAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Green;
                    this.answerButton2.BackColor = Color.Red;
                    this.answerButton3.BackColor = Color.Red;
                    break;

                case 2:
                    this.correctAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Red;
                    this.answerButton2.BackColor = Color.Green;
                    this.answerButton3.BackColor = Color.Red;
                    break;

                case 3:
                    this.wrongAnswerCounter ++;
                    this.answerButton1.BackColor = Color.Red;
                    this.answerButton2.BackColor = Color.Red;
                    this.answerButton3.BackColor = Color.Green;
                    break;

                default:
                    MessageBox.Show("Error from correctAnswer button 2");
                    break;
            }
            UpdatePanel();
            DisableQuestionButtons();
            if (!won && !loose)
            {
                this.answerGivenCountuer++;
                WinCondiction();
            }

            this.questionManager.GetQuestion().answerGiven = 2;
        }
        /*Answer Button 3*/
        private void answerButton3_Click(object sender, EventArgs e)
        {
            this.answerButton3.Text = "X";

            switch (this.questionManager.GetQuestion().correctAnswer)
            {
                case 1:
                    this.wrongAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Green;
                    this.answerButton2.BackColor = Color.Red;
                    this.answerButton3.BackColor = Color.Red;
                    break;

                case 2:
                    this.wrongAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Red;
                    this.answerButton2.BackColor = Color.Green;
                    this.answerButton3.BackColor = Color.Red;
                    break;

                case 3:
                    this.correctAnswerCounter ++ ;
                    this.answerButton1.BackColor = Color.Red;
                    this.answerButton2.BackColor = Color.Red;
                    this.answerButton3.BackColor = Color.Green;
                    break;

                default:
                    MessageBox.Show("Error from correctAnswer button 3");
                    break;
            }
            UpdatePanel();
            DisableQuestionButtons();
            if(!won && !loose)
            {
                this.answerGivenCountuer++;
                WinCondiction();
            }

            this.questionManager.GetQuestion().answerGiven = 3;
        }

        /*this is the button that open the form to edit the quiz*/
        private void questionsEditorButton_Click(object sender, EventArgs e)
        {
            if (!programStatus)
            {
                this.editor.ShowDialog();
            }
        }

        /*last button added is the button that upload the question*/
        private void searchQuestionButton_Click(object sender, EventArgs e)
        {
            if (!searchStatus)
            {
                this.searchStatus = true;
                EnableNavigationButtons();
                this.startbutton.Enabled = false;
            }

            this.totalQuestionsBox.Text = "\u221E";

            if (!Regex.IsMatch(this.searchQuestionTextBox.Text, @"^\d+$"))
            {
                MessageBox.Show("Il parametro di ricerca non è valido");
                return;
            }


            int localIndex = Int32.Parse(this.searchQuestionTextBox.Text) -1;

            if(questionManager.AskQuestion(localIndex) is null)
            {
                MessageBox.Show("Domanda già cercata");
                return;
            }

            ResetButtons();
            EnableQuestionButtons();
            WriteQuestions();
            UpdatePanel();
            LimitCounter();
        }
    }
}
