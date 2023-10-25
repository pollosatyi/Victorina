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
           quizzes= _victorinaService.Play();
            Console.WriteLine("НУЫ");
        }

    }
}
