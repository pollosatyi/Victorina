using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victoria.BLL;

namespace VictorinaUI
{
    public static class CreateVictorinaUI
    {
        private static IVictorinaService _victorinaService = new VictorinaService();

        public static void CreateVictorina()
        {
            string question = InitQuestion();
            List<List<string>> answers = new List<List<string>>(InitAnswers());
            _victorinaService.Create(question, answers);

        }



        private static string InitQuestion()
        {
            string question = "";
            Console.WriteLine("Введите вопрос: ");
            question = Console.ReadLine();
            return question;
        }


        private static List<List<string>> InitAnswers()
        {
            List<List<string>> answers = new List<List<string>>();
            for (int i = 0; i < 4; i++)
            {
                answers.Add(InitAnswer());
            }
            return answers;
        }

        private static List<string> InitAnswer()
        {
            List<string> newAnswer = new List<string>();
            Console.WriteLine("Введите ответ: ");
            newAnswer.Add(Console.ReadLine());
            Console.WriteLine("Введите 1 если ответ верный или 0, если неверный");
            int check = int.Parse(Console.ReadLine());
            newAnswer.Add((check != 0) ? ("True") : ("False"));
            return newAnswer;

        }

    }
}
