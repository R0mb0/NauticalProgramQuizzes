using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DefinitiveNauticalProject.Questions;
using Newtonsoft.Json;

namespace DefinitiveNauticalProject.Utility
{
    static class QuestionInserter
    {
        public static bool Inserter(List<Question> list, bool limited, int start, int stop)
        {
            if (limited)
            {
                if (System.IO.File.Exists("12Miles.txt"))
                {
                    for (int i = start - 1; i < stop; i++)
                    {
                        list.Add((Question)DatabaseQuestions.Within12miles[i].Clone());
                    }

                    return true;
                }
                else
                {
                    if (System.IO.File.Exists("test.txt"))
                    {
                        String json = File.ReadAllText("test.txt");/*read the file created*/
                        List<Question> temp = JsonConvert.DeserializeObject<List<Question>>(json);/*deserialize the salved database*/

                        for (int i = start - 1; i < stop; i++)
                        {
                            list.Add((Question)temp[1].Clone());
                        }

                        MessageBox.Show("Ho caricato il test");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Errore nel caricamento delle domande");
                        return false;
                    }
                }
                
            }
            else
            {
                if (System.IO.File.Exists("Integration.txt"))
                {
                    for (int i = start - 1; i < stop; i++)
                    {
                        list.Add((Question)DatabaseQuestions.Beyond12miles[i].Clone());
                    }

                    return true;
                }
                else
                {
                    if (System.IO.File.Exists("test.txt"))
                    {
                        String json = File.ReadAllText("test.txt");/*read the file created*/
                        List<Question> temp = JsonConvert.DeserializeObject<List<Question>>(json);/*deserialize the salved database*/

                        for (int i = start - 1; i < stop; i++)
                        {
                            list.Add((Question)temp[1].Clone());
                        }

                        MessageBox.Show("Ho caricato il test");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Errore nel caricamento delle domande");
                        return false;
                    }
                }

                
            }
        }
    }
}
