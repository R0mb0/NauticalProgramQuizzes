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


namespace DefinitiveNauticalProject
{
    public partial class QuizzesPanel : Form
    {
        /*Fields*/
        private bool programStatus; /*used to protect the phases of the program*/
        private int correctAnswerCounter = 0; /* used to counter the answers given*/
        private int wrongAnswerCounter = 0;/* used to counter the wrong answers given*/
        private int answerGivenCountuer = 0;/* used to counter cprrect the answers given*/
        /*list*/
        private List<Question> questionList { get; } 
        private int indexList;
        /*Prepare the second form to be opened*/
         QuestionsEditor editor;

        /*-----------------------------------------------------------------------------------------*/

        /*BUILDER*/
        public QuizzesPanel()
        {
            InitializeComponent();
            DisableActionButtons();
            DisableNavigationButtons();
            questionList = new List<Question>();
            Index list = 0;
            
            this.editor = new QuestionsEditor();
        }

        /*--------------------------------------PRIVATE FUNCTIONALITY METHOD---------------------------------------------------*/
        /*is used to represent a index that is human readble*/
        private int GraphicIndex()
        {
            return this.indexList +1;
        }

        private void InsertQuestions(bool limited, int start, int stop)
        {
            if (!QuestionInserter.Inserter(this.questionList, limited, start, stop))
            {
                MessageBox.Show("Errore nel database");
                this.startbutton.Enabled = false;
            }

            this.totalQuestionsBox.Text = this.questionList.Count.ToString();
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

        private void DisableNavigationButtons()
        {
            this.prewButton.Enabled = false;
            this.nextButton.Enabled = false;
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
            this.questionBox.Text = this.questionList[indexList].question;
            this.questionNumberBox.Text = "Numero Quiz:\n" + this.questionList[indexList].questionNumber.ToString();
            this.answerBox1.Text = this.questionList[indexList].answer1;
            this.answerBox2.Text = this.questionList[indexList].answer2;
            this.answerBox3.Text = this.questionList[indexList].answer3;
            this.imageBox.Image = ImageUtil.GetImageFromString(this.questionList[indexList].B64image);
            
        }

       /*this method is usefull to see the status of the answer given, it permit to see the result, but is impossible change it*/
        private void GlobalPaint()
        {
            if (this.questionList[indexList].answerGiven != 0)
            {
                switch (this.questionList[indexList].correctAnswer)
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

                switch (this.questionList[indexList].answerGiven)
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
            if (this.questionList.Count == 1)
            {
                DisableNavigationButtons();
            }
            else
            {
                if (GraphicIndex() == 1)
                {
                    this.prewButton.Enabled = false;
                    this.nextButton.Enabled = true;
                }
                else
                {
                    if (GraphicIndex() == this.questionList.Count)
                    {
                        this.prewButton.Enabled = true;
                        this.nextButton.Enabled = false;
                    }
                    else
                    {
                        EnableNavigationButtons();
                    }
                }
            }
        }

        /*-----------------------------------GUI BUTTONS-------------------------------------------------------------*/

        

        /*===========================================================================================*/
        /*Stop Method, reset of the component method*/
        private void stopButton_Click(object sender, EventArgs e)
        {
            this.startbutton.Enabled = true;
            this.entro12MigliaToolStripMenuItem.Enabled = true;
            this.oltre12MigliaToolStripMenuItem.Enabled = true;
            ResetQuestion();
            this.questionList.Clear();

            /*textbox reset*/
            this.CurrentQuestionBox.Clear();
            this.totalQuestionsBox.Clear();
            this.correctAnswerBox.Clear();
            this.wrongAnswerBox.Clear();
            this.chapterTextBox.Clear();
            
            /*Button reset*/
            this.startbutton.BackColor = Color.LightGray;

            this.indexList = 0;
            this.correctAnswerCounter = 0;
            this.wrongAnswerCounter = 0;
            this.answerGivenCountuer = 0;
            
            DisableActionButtons();
            DisableNavigationButtons();
        }


        /*Start button refernce*/
        private void startbutton_Click(object sender, EventArgs e)
        {
            this.startbutton.Enabled = false;
            this.entro12MigliaToolStripMenuItem.Enabled = false; ;
            this.oltre12MigliaToolStripMenuItem.Enabled = false; ;

            if (this.programStatus)
            {
               
                if(this.questionList.Count > 0)
                {
                    this.startbutton.BackColor = Color.MediumVioletRed;
                    EnableQuestionButtons();
                    LimitCounter();
                    WriteQuestions();
                    UpdatePanel();
                }
                else
                {
                    MessageBox.Show("Non è stato possibile raggiungere il database");
                }

                
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

            if(this.indexList - 1 >= 0)
            {
                this.indexList --;
            }

            if (this.questionList[indexList].answerGiven != 0)
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
            
            
           if (GraphicIndex() != this.questionList.Count)
           {
                    this.indexList ++;
           }
           
            if (this.questionList[indexList].answerGiven != 0)
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

            switch (this.questionList[indexList].correctAnswer)
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
            this.answerGivenCountuer++;   
            questionList[indexList].answerGiven = 1;
        }
        /*Answer Button 2*/
        private void answerButton2_Click(object sender, EventArgs e)
        {
            this.answerButton2.Text = "X";

            switch (this.questionList[indexList].correctAnswer)
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
            this.answerGivenCountuer++;
            questionList[indexList].answerGiven = 2;
        }
        /*Answer Button 3*/
        private void answerButton3_Click(object sender, EventArgs e)
        {
            this.answerButton3.Text = "X";

            switch (this.questionList[indexList].correctAnswer)
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
            this.answerGivenCountuer++;
            questionList[indexList].answerGiven = 3;
        }

        /*the last button added is the button tha open the form to edit the quiz*/
        private void questionsEditorButton_Click(object sender, EventArgs e)
        {
            if (!programStatus)
            {
                this.editor.ShowDialog();
            }
        }

        /*============================Tool strip whithin 12 miles part========================================*/

        /*Teoria della nave*/
        private void teoriaDellaNaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Elementi di teoria della nave -> Teoria della nave";
            InsertQuestions(true,1,72);
        }

        private void elicaETimoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Elementi di teoria della nave -> Elica e timone";
            InsertQuestions(true, 73, 135);
        }

        /*Motore*/
        private void motoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Motore -> Teoria motore";
            InsertQuestions(true, 136, 199);
        }

        private void calcoloDellaAutonomiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Motore -> Calcolo della autonomia";
            InsertQuestions(true, 200, 220);
        }

        /*Regolamenti di sicurezza*/
        private void dotazioniDiBordoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Dotazioni di bordo";
            InsertQuestions(true, 221, 245);
        }

        private void tipiDiVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Tipi di visite";
            InsertQuestions(true, 246, 258);
        }

        private void fallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Falla";
            InsertQuestions(true, 259, 260);
        }

        private void incendioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Incendio";
            InsertQuestions(true, 261, 270);
        }

        private void uomoInMareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Uomo in mare";
            InsertQuestions(true, 271, 275);
        }

        private void provvedimantiPerLaSalvezzaDellePersoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Provvedimenti per la salvezza delle persone";
            InsertQuestions(true, 276, 277);
        }

        private void precauzioniDaAdottarePerTempoCattivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Precauzioni da adottare per tempo cattivo";
            InsertQuestions(true, 278, 283);
        }

        private void assistenzaESoccorsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di sicurezza -> Assistenza e soccorso";
            InsertQuestions(true, 284, 299);
        }

        /*Regolamenti di navigazione*/
        private void normeEFanaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di navigazione -> Norme e fanali";
            InsertQuestions(true, 300, 474);
        }

        private void navigazioneFluvialeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di navigazione -> Navigazione fluviale";
            InsertQuestions(true, 475, 483);
        }

        private void precauzioniInProssimitàDellaCosta79ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Regolamenti di navigazione -> Precauzioni in prossimità della costa";
            InsertQuestions(true, 484, 562);
        }

        /*Meteo*/
        private void bollettiniMeteorologiciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Bollettini meteorologi";
            InsertQuestions(true, 563, 627);
        }

        /*Coordinate geografiche*/
        private void coordinateGeograficheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Coordinate geografiche";
            InsertQuestions(true, 628, 671);
        }

        private void carteNeutiche92ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Carte nautiche";
            InsertQuestions(true, 672, 763);
        }

        private void rosaDeiVenti7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Rosa dei venti";
            InsertQuestions(true, 764, 770);
        }

        private void bussola53ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Bussola";
            InsertQuestions(true, 771, 823);
        }

        private void navigazioneStimata56ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Navigazione stimata";
            InsertQuestions(true, 824, 879);
        }

        private void navigazioneCostiera41ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Navigazione costiera";
            InsertQuestions(true, 880, 920);
        }

        private void proraERotta42ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Prora e rotta";
            InsertQuestions(true, 921, 962);
        }

        private void solcometriEScandagli9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Solcometri e scandagli";
            InsertQuestions(true, 963, 971);
        }

        private void elencoDeiFariESegnaliDaNebbia68ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Coordinate geografiche -> Elenco fari e segnali da nebbia";
            InsertQuestions(true, 972, 1040);
        }

        /*Leggi e regolemnti per la navigazione*/
        private void regolamentiPerLaNavigazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Leggi e regolemnti per la navigazione -> Regolamenti per la navigazione";
            InsertQuestions(true, 1041, 1132);
        }

        private void sciNautico20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Entro 12 Miglia -> Leggi e regolemnti per la navigazione -> Sci nautico";
            InsertQuestions(true, 1133, 1152);
        }

        /*============================Tool strip whithin 12 miles part========================================*/

        /*Cenni di galleggiamento e stabilità */
        private void cenniDiGalleggiamentoEStabilità32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Cenni di galleggiamento e stabilità";
            InsertQuestions(false,1, 32);
        }

        /*Prevenzione incendi*/
        private void prevenzioneIncendi24ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Prevenzione incendi";
            InsertQuestions(false, 33, 56);
        }

        /*Meteo*/
        private void meteorologia86ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Meteorologia";
            InsertQuestions(false, 57, 142);
        }

        /*Magnetismo terrestre e navale*/
        private void magnetismoTerrestreENavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Magnetismo terrestre e navale";
            InsertQuestions(false, 143, 173);
        }

        private void ortodromiaELossodromia15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Ortodromia e lossodromia";
            InsertQuestions(false, 174, 188);
        }

        private void astronomia2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Astronomia";
            InsertQuestions(false, 189, 190);
        }

        private void navigazioneCostiera41ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Navigazione costiera";
            InsertQuestions(false, 191, 231);
        }

        private void radio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Radio";
            InsertQuestions(false, 232, 233);
        }

        private void radionavigazione5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Radionavigazione";
            InsertQuestions(false, 234, 238);
        }

        private void fusiOrari20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Fusi orari";
            InsertQuestions(false, 239, 258);
        }

        private void pubblicazioniNautiche6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Pubblicazioni nautiche";
            InsertQuestions(false, 259, 264);
        }

        private void comunicazioniRadiotelefoniche11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Comunicazioni radiotelefoniche";
            InsertQuestions(false, 265, 275);
        }

        private void maree6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Magnetismo terrestre e navale -> Maree";
            InsertQuestions(false, 276, 281);
        }

        /*Locazione e noleggio*/
        private void localizzazioneENoleggioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Locazione e noleggio -> Locazione e noleggio";
            InsertQuestions(false, 282, 287);
        }

        private void dotazioniDiBordoSenzaLimiti21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableActionButtons();
            this.chapterTextBox.Text = "Oltre 12 Miglia -> Locazione e noleggio -> Dotazioni di bordo senza limiti";
            InsertQuestions(false, 288, 308);
        }

    }
}
