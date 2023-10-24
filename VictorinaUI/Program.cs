using VictorinaUI;

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

            break;
        case StartMenuEnum.ChooseQuiz:

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
