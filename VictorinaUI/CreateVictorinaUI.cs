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

        public static  void CreateVictorina()
        {
           string question=InitQuestion();
           Dictionary<bool,string>answers = new Dictionary<bool,string>(InitAnswers());
            _victorinaService.Create(question,answers);

        }



        private static string InitQuestion()
        {
            string question = "";
            Console.WriteLine("Введите вопрос: ");
            question = Console.ReadLine();
            return question;
        }


        private static Dictionary<bool, string> InitAnswers()
        {
            Dictionary<bool, string> answers = new Dictionary<bool, string>();
            for (int i = 0; i < 4; i++)
            {
                string answer = "";
                int check = 0;
                bool IsRightAnswer;
                Console.WriteLine("Введите ответ: ");
                answer = Console.ReadLine();
                Console.WriteLine("Если ответ неверный нажмите 0 или любую цифру если верный ");
                check = int.Parse(Console.ReadLine());
                IsRightAnswer = (check != 0) ? (true) : (false);
                answers.Add(IsRightAnswer, answer);
            }
            return answers;
        }

    }
}
