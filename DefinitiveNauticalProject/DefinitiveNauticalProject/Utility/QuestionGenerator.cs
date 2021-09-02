using DefinitiveNauticalProject.Questions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DefinitiveNauticalProject.Utility;

namespace DefinitiveNauticalProject.Utility
{
    static class QuestionGenerator
    {
        private static bool limit;
        private static List<int> numbers = new List<int>();

        /*This method provide to generat the random number of the quiz within a range of value*/
        private static void RandomGenerator()
        { 
            /*Within 12 miles questions numbers*/
            if (limit)
            {
                int randomNumber;
                int cycle;

                /*Teoria della nave*/
                cycle = 2;
                while (cycle>0)
                {
                    randomNumber = CPURandom.Next(1, 135);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }
                   
                }

                /*Motori endotermici*/
                cycle = 2;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(136, 220);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Sicurezza della navigazione*/
                cycle = 4;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(221, 299);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Regolamento marittimo*/
                cycle = 5;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(300, 562);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Meteo*/
                cycle = 2;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(563, 627);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Navigazione*/
                cycle = 4;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(628, 1040);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Sicurezza della navigazione*/
                cycle = 1;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(1041, 1152);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                if(numbers.Count < 20)
                {
                    MessageBox.Show("Problemi con i numeri della lista");
                }
            }
            /*beyond 12 miles questions*/
            else
            {
                int randomNumber;
                int cycle;

                /*Teoria della nave*/
                cycle = 2;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(1, 32);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Sicurezza della navigazione*/
                cycle = 1;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(33, 56);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Meteo*/
                cycle = 5;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(57, 142);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Navigazione*/
                cycle = 4;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(143, 281);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                /*Normativa diportista*/
                cycle = 1;
                while (cycle > 0)
                {
                    randomNumber = CPURandom.Next(282, 308);
                    if (!numbers.Contains(randomNumber))
                    {
                        numbers.Add(randomNumber);
                        cycle--;
                    }

                }

                if (numbers.Count < 13)
                {
                    MessageBox.Show("Problemi con i numeri della lista");
                }

            }
        }


        public static void CreateQuestions(bool limitEntry, List<Question> insertList)
        {

            limit = limitEntry;

            if (numbers.Count > 0)
            {
                numbers.Clear();
            }

            RandomGenerator();

            if (limit)
            {

                if (DatabaseQuestions.Within12miles.Count < 1152)
                {
                    if (System.IO.File.Exists("test.txt"))
                    {
                        String json = File.ReadAllText("test.txt");/*read the file created*/
                        List<Question> temp = JsonConvert.DeserializeObject<List<Question>>(json);/*deserialize the salved database*/

                        for (int i = 0; i < 20; i++)
                        {
                            insertList.Add(temp[i]);
                        }

                        MessageBox.Show("Ho caricato il test");
                    }
                    else
                    {
                        insertList.Clear();
                        MessageBox.Show("Errore nel caricamento del database");
                    }
                    
                    

                }
                else
                {
                    numbers.ForEach(delegate (int index)
                    {
                        insertList.Add((Question)DatabaseQuestions.Within12miles[index].Clone());
                    });
                }
  
            }
            else
            {

                if (DatabaseQuestions.Beyond12miles.Count < 308)
                {
                    if (System.IO.File.Exists("test.txt"))
                    {
                        String json = File.ReadAllText("test.txt");/*read the file created*/
                        List<Question> temp = JsonConvert.DeserializeObject<List<Question>>(json);/*deserialize the salved database*/

                        for (int i = 0; i < 13; i++)
                        {
                            insertList.Add(temp[i]);
                        }

                        MessageBox.Show("Ho caricato il test");
                    }
                    else
                    {
                        insertList.Clear();
                        MessageBox.Show("Errore nel caricamento del database");
                    }



                }
                else
                {
                    numbers.ForEach(delegate (int index)
                    {
                        insertList.Add((Question)DatabaseQuestions.Beyond12miles[index].Clone());
                    });
                }
                
            }
        }





    }
}
