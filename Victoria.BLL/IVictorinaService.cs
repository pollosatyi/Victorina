using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victoria.BLL
{
    public interface IVictorinaService
    {
        public void Create(string question, List<List<string>> answers);
    }
}
