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
                quizzes = FileReader(PATH);
            }

            quizzes.Add(quiz);
            Write(quizzes);
        }

        public  List<Quiz> Play()
        {
            var quizzes= new List<Quiz>();
            quizzes = FileReader(PATH);
            return quizzes;
        }

        private void Write(List<Quiz> quest)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                System.Text.Json.JsonSerializer.Serialize<List<Quiz>>(fs, quest);
            }
        }

        private List<Quiz> FileReader(string Path)
        {
            var quizzes = new List<Quiz>();
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string json = sr.ReadToEnd();
                    quizzes = DeserializeQuiz(json);
                }
            }
            return quizzes;
        }

        private List<Quiz> DeserializeQuiz(string json)
        {
            var quizzes = new List<Quiz>();
            string[] jsonMassString = json.Split('{');
            int jsonMassStringCount = jsonMassString.Length;

            for (int i = 1; i < jsonMassStringCount; i++)
            {
                List<List<string>> newList = new List<List<string>>();

                int indexOfQuestionStart = jsonMassString[i].IndexOf(':');
                int indexofQuestionEnd = jsonMassString[i].IndexOf(',');
                int sizeQuestion = indexofQuestionEnd - indexOfQuestionStart;
                string question = jsonMassString[i].Substring(indexOfQuestionStart + 2, sizeQuestion - 3);
                string[] jsonAnswers = jsonMassString[i].Split("_answers\":[");

                string[] jsonAnswersBlok = jsonAnswers[1].Split(']');
                for (int j = 0; j < 4; j++)
                {
                    string answerBlok = "";
                    string answerBool = "";
                    int indexOfAnswerBlokEnd = 0;
                    int indexOfAnswerBool = 0;
                    jsonAnswersBlok[j] = jsonAnswersBlok[j].TrimStart(',', '[', '\"').TrimEnd('\"');
                    indexOfAnswerBlokEnd = jsonAnswersBlok[j].IndexOf('\"');
                    indexOfAnswerBool = jsonAnswersBlok[j].IndexOf(',') + 2;
                    answerBlok = jsonAnswersBlok[j].Substring(0, indexOfAnswerBlokEnd);
                    answerBool = jsonAnswersBlok[j].Substring(indexOfAnswerBool);
                    List<string> newList2 = new List<string>() { answerBlok, answerBool };
                    newList.Add(newList2);

                }
                Quiz newQuiz = new Quiz(question, newList);
                quizzes.Add(newQuiz);

            }
            return quizzes;
        }
    }
}
