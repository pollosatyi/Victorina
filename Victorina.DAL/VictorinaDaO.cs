using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Victorina.Core;

namespace Victorina.DAL
{
    public class VictorinaDaO : IVictoryDaO
    {
        private const string PATH = "D:\\sergey t\\Victorina\\VictorinaJson\\victorina.json";

        public void Create(Quest quest)
        {
            var quests = new List<Quest>();

            if (File.Exists(PATH))
            {
                using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
                {
                    quests = JsonSerializer.Deserialize<List<Quest>>(fs);
                }
            }

            quests.Add(quest);
            Write(quests);
        }

        private void Write(List<Quest> quest)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Quest>>(fs, quest);
            }
        }
    }
}
