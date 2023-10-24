﻿
using Victorina.Core;
using Victorina.DAL;

namespace Victoria.BLL
{
    public class VictorinaService : IVictorinaService
    {
        private readonly IVictoryDaO _victoryDao = new VictorinaDaO();
        public void Create(string question, Dictionary<bool, string> answers)
        {
            var quiz = new Quiz(question,answers);
            _victoryDao.Create(quiz);
        }

        

        


    }

}
