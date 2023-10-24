using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Victorina.Core;

namespace Victorina.DAL
{
    public class VictorinaDaO : IVictoryDaO
    {
        private const string PATH = "D:\\Parsing\\victorina.json";

        public void Create(Quiz quiz)
        {
            var quizzes = new List<Quiz>();

            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    quizzes = JsonSerializer.Deserialize<List<Quiz>>(fs);
                }
            }

            quizzes.Add(quiz);
            Write(quizzes);
        }

        private void Write(List<Quiz> quest)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Quiz>>(fs, quest);
            }
        }
    }
}
