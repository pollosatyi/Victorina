using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Victorina.Core;

namespace Victorina.DAL
{
    public interface IVictoryDaO
    {
        void Create(Quiz quest);
        List<Quiz> Play();
    }
}
