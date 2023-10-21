using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Victorina.UI
{
    public  class Quests
    {
        bool isRun = true;

        while (isRun)
        {
            Console.WriteLine("выбрать действие: ");
            Console.WriteLine("1- создать викторину ");
            Console.WriteLine("2- выбрать викторину ");
            Console.WriteLine("3- выйти ");

            StartMenuEnum userInput;
            try
            {
                userInput = (StartMenuEnum) Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.Clear();
                continue;
            }
        }

    }
 
}
