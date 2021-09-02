using DefinitiveNauticalProject.Questions;
using DefinitiveNauticalProject.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DefinitiveNauticalProject
{
    class QuestionManager
    {
        /*Use singleton pattern, because i can have only one istance*/

        /*fields*/
        private bool limit;
        private List<Question> questionList { get; }
        private int indexList;

        /*Builder*/
        public QuestionManager (bool limit)
        {
            this.limit = limit;
            this.indexList = 0;
            this.questionList = new List<Question>();
        }

        /*=========================================Private Methods=================================================*/

        private bool DuplicateQuestionsChecker(int number)
        {

            bool temp = false;
            this.questionList.ForEach(delegate(Question question)
            {
                if(number == question.questionNumber)
                {
                    temp = true;
                }
            });

            if (temp)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /*=========================================Public Methods==================================================*/
        public int ControlPosiction()
        {
            if (this.questionList.Count > 1)
            {

                if (this.indexList == 0)
                {
                    return MagicNumbers.tail;
                }
                else
                {
                    if (this.indexList == this.questionList.Count - 1)
                    {
                        return MagicNumbers.head;
                    }
                    else
                    {
                        return MagicNumbers.center;
                    }
                }

            }
            else
            {
                return MagicNumbers.oneElement;
            }
        }

        public bool IndexIncrement()
        {
            if (limit)
            {
                if(this.indexList +1< Constants.Within12QuestionsLimit && this.indexList +1 <= this.questionList.Count)
                {
                    this.indexList ++;
                    return true;
                }
                return false;
            }
            else
            {
                if (this.indexList +1 < Constants.Beyond12QuestionsLimit && this.indexList +1 <= this.questionList.Count)
                {
                    this.indexList++;
                    return true;
                }
                return false;
            }
        }

        public bool IndexDecrement()
        {
            if(this.indexList-1 >= 0)
            {
                this.indexList--;
                return true;
            }

            return false;
        }

        public int GetIndex()
        {
            return this.indexList;
        }

        /*this method provide to return the current question*/
        public Question GetQuestion()
        {
            if (this.questionList.Count == 0)
            {
                return null;
            }

            return this.questionList[indexList];
        }

        /*This method provide to generate an entire list of questions*/
        public Question AskQuestionList()
        {
            this.indexList = 0;
            QuestionGenerator.CreateQuestions(this.limit, this.questionList);

            return GetQuestion();
        }


        /*This method is usefull to recive a single question from the database, thids question will be inserted into the list of question*/
        public Question AskQuestion (int index)
        {

            if (DuplicateQuestionsChecker(index + 1))
            {
                return null;
            }

            if (limit)
            {
                if(index >= 0 && index <= Constants.Within12Limit)
                {
                    this.questionList.Add((Question)DatabaseQuestions.Within12miles[index].Clone());
                    this.indexList = this.questionList.Count - 1;
                }
            }
            else
            {
                if (index >= 0 && index <= Constants.Beyond12Limit)
                {
                    this.questionList.Add((Question)DatabaseQuestions.Beyond12miles[index].Clone());
                    this.indexList = this.questionList.Count - 1;
                }
            }

            return GetQuestion();
        }
    }
}
