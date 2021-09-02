using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace DefinitiveNauticalProject.Questions
{
    class Question : ICloneable
    {
        /*Fields*/
        public int questionNumber { get; }
        public string question { get; }
        public string answer1 { get; }
        public string answer2 { get; }
        public string answer3 { get; }

        /*correct answer is a number 1 to 3 from the answer 1*/
        public int correctAnswer { get; }
        public int answerGiven { get; set; }

        public string B64image { get; }

        /*==============================Private Methods================================*/
        private bool StringNumberControl(string s)
        {
            return Regex.IsMatch(s, @"^\d+$");
        }

        /*==============================Public Methods================================*/

        public Question(int questionNumber, string question, string answer1, string answer2, string answer3, int correctAnswer, string B64image)
        {
            this.questionNumber = questionNumber;
            this.question = question;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;

            if(correctAnswer>=1 && correctAnswer <= 3)
            {
                this.correctAnswer = correctAnswer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The correct answer number is too small or too big");
            }
            this.answerGiven = 0;
            this.B64image = B64image;



        }

        /*this method is used to clone the element from a list to another*/
        public object Clone()
        {
            return new Question(this.questionNumber, this.question, this.answer1, this.answer2, this.answer3, this.correctAnswer, this.B64image);
        }
    }
}
