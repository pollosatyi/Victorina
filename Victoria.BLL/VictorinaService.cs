
using Victorina.Core;
using Victorina.DAL;

namespace Victoria.BLL
{
    public class VictorinaService : IVictorinaService
    {
        private readonly IVictoryDaO _victoryDao = new VictorinaDaO();
        public void Create()
        {
            var quest= new Quiz();
            _victoryDao.Create(quest);
        }

        public string Qu
    }

}
