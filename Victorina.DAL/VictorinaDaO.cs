using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Victorina.DAL
{
    public class VictorinaDaO : IVictoryDaO
    {
        private const string PATH = "D:\\sergey t\\Victorina\\VictorinaJson\\victorina.json";

        public void Create(Victorina victorina)
        {
            var victorinas = new List<Victorina>();

            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    victorinas = JsonSerializer.Deserialize<List<Victorina>>(fs);
                }
            }

            victorinas.Add(victorina);
            Write(libraries);
        }

        private void Write(List<Victorina> victorina)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Victorina>>(fs, victorina);
            }
        }
    }
}
