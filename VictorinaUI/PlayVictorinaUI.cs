using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victoria.BLL;
using Victorina.Core;

namespace VictorinaUI
{
    public static class PlayVictorinaUI
    {
        private static IVictorinaService _victorinaService = new VictorinaService();

        public static void PlayVictorina()
        {
            var quizzes = new List<Quiz>();
            int quizPoints = 0;
            quizzes = _victorinaService.Play();
            Console.WriteLine("Начало игры");
            for (int i = 0; i < quizzes.Count; i++)
            {
                int rightNumberAnswer = 0;
                Console.WriteLine(quizzes[i]._question);
                Console.WriteLine("Варианты ответов: ");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"{j + 1}. {quizzes[i]._answers[j][0]}");
                    if (quizzes[i]._answers[j][1].Equals("True"))
                    {
                        rightNumberAnswer = j;
                    }
                }
                Console.WriteLine("Выберите номер правильного ответа");
                int numberAnswer = int.Parse(Console.ReadLine()) - 1;
                if (quizzes[i]._answers[numberAnswer][1].Equals("True"))
                {
                    Console.WriteLine("Это верный ответ");
                    Console.WriteLine();
                    quizPoints++;
                }
                else
                {
                    Console.WriteLine("Это неверный ответ");
                    Console.WriteLine($"Правильный ответ: {quizzes[i]._answers[rightNumberAnswer][0]}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Викторина пройдена");
            Console.WriteLine($"Правильных ответов {quizPoints} из {quizzes.Count}");
            Console.WriteLine();
        }

    }
}
