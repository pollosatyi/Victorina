
using Victorina.Core;
using Victorina.DAL;

namespace Victoria.BLL
{
    public class VictorinaService : IVictorinaService
    {
        private readonly IVictoryDaO _victoryDao = new VictorinaDaO();
        public void Create()
        {
            var quiz = new Quiz( question, InitAnswers());
            _victoryDao.Create(quiz);
        }

        public string InitQuestion()
        {
            string question = "";
            Console.WriteLine("Введите вопрос: ");
            question = Console.ReadLine();
            return question;
        }

        public Dictionary<bool, string> InitAnswers()
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
