using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DefinitiveNauticalProject.LoadingForm;

namespace DefinitiveNauticalProject.Questions
{
     static class DatabaseQuestions
    {
        /*list within 12 miles*/
        private static List<Question> within12miles;
         public static List<Question> Within12miles
        {
            get
            {
                if (within12miles != null)
                {
                    return within12miles;
                }
                else
                {

                    if (System.IO.File.Exists("12Miles.txt"))
                    {
                        Loading.ShowLoading();
                        String json = File.ReadAllText("12Miles.txt");/*read the file created*/
                        within12miles = JsonConvert.DeserializeObject<List<Question>>(json);/*deserialize the salved database*/
                        Loading.CloseLoading();
                    }
                    else
                    {
                        within12miles = new List<Question>();
                    }

                    return within12miles;
                }

                
            }
            set
            {
                within12miles = value;
            }
        }

        /*list beyond 12 miles*/
        private static List<Question> beyond12miles;
         public static List<Question> Beyond12miles
        {
            get
            {
                if (beyond12miles != null)
                {
                    return beyond12miles;
                }
                else
                {

                    if (System.IO.File.Exists("Integration.txt"))
                    {
                        Loading.ShowLoading();
                        String json = File.ReadAllText("Integration.txt");/*read the file created*/
                        beyond12miles = JsonConvert.DeserializeObject<List<Question>>(json);/*deserialize the salved database*/
                        Loading.CloseLoading();
                    }
                    else
                    {
                        beyond12miles = new List<Question>();
                    }

                    return beyond12miles;
                }
            }

            set
            {
                beyond12miles = value;
            }
        }


        public static bool SaveDatabase(bool limit)
        {
            String json;
            if (limit)
            {
                json = JsonConvert.SerializeObject(within12miles);/*serialize the database*/
                System.IO.File.WriteAllText("12Miles.txt", json);/*writing od the serialized database*/

                if (File.Exists("12Miles.txt"))
                {
                    return true;
                }

                return false;
            }
            else
            {
                json = JsonConvert.SerializeObject(beyond12miles);/*serialize the database*/
                System.IO.File.WriteAllText("Integration.txt", json);/*writing od the serialized database*/

                if (File.Exists("Integration.txt"))
                {
                    return true;
                }

                return false;
            }
            
            

            
        }

    }
}
