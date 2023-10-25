using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Victorina.Core;
using Newtonsoft.Json;

namespace Victorina.DAL
{
    public class VictorinaDaO : IVictoryDaO
    {
        private const string PATH = "C:\\Parsing\\victorina.json";

        public void Create(Quiz quiz)
        {
            var quizzes = new List<Quiz>();
            List<List<string>> quizzesString = new List<List<string>>();

            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                   using (StreamReader sr = new StreamReader(fs))
                    {
                        string json= sr.ReadToEnd();
                         dynamic Data = JsonConvert.DeserializeObject(json);
                        foreach(var item1 in Data)
                        {
                            List<string> list1 = new List<string>();
                            foreach(var item2 in item1)
                            {
                                list1.Add(item2.ToString());
                            }
                            quizzesString.Add(list1);
                        }
                    }
                    
                }
            }

            quizzes.Add(quiz);
            Write(quizzes);
        }

        private  List<string> r (FileStream fs)
        {
            throw new NotImplementedException();
        }

        private void Write(List<Quiz> quest)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                System.Text.Json.JsonSerializer.Serialize<List<Quiz>>(fs, quest);
            }
        }
    }
}
