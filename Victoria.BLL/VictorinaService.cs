
using Victorina.Core;
using Victorina.DAL;

namespace Victoria.BLL
{
    public class VictorinaService : IVictorinaService
    {
        private readonly IVictoryDaO _victoryDao = new VictorinaDaO();
        public void Create(string name, int questionCount)
        {
            var quest= new Quest(name, questionCount);
            _victoryDao.Create(quest);
        }
    }

}
