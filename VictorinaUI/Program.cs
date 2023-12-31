﻿using Victoria.BLL;
using Victorina.Core;
using VictorinaUI;

bool isRun = true;

while (isRun)
{
    Console.WriteLine("выбрать действие: ");
    Console.WriteLine("1 - создать викторину ");
    Console.WriteLine("2 - сыграть в  викторину ");
    Console.WriteLine("3 - очистить консоль");
    Console.WriteLine("4- выйти ");


    StartMenuEnum userInput;
    try
    {
        userInput = (StartMenuEnum)Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.Clear();
        continue;
    }

    switch (userInput)
    {
        case StartMenuEnum.CreateQuiz:

            CreateVictorinaUI.CreateVictorina();
            break;
        case StartMenuEnum.PlayQuiz:
            PlayVictorinaUI.PlayVictorina();
            break;
        case StartMenuEnum.Clear:
            Console.Clear();
            break;
        case StartMenuEnum.Exit:
            isRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Неизвестная enum");
            Console.WriteLine();
            break;
    }
}
