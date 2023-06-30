// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

main();

void main()
{
    bool isWorking = true;

    while (isWorking)
    {
        Console.WriteLine("input task number");
        string task = Console.ReadLine();
        switch (task)
        {
            case "exit": isWorking = false; break;
            case "15": Console.WriteLine("is it a day off?"); task1();break;
            default:
                break;
        }
    }
}

void task1()
{
    Console.WriteLine(IsdayOff(ReadInt()));
}


int ReadInt()
{
    int number ;

    Console.WriteLine("enter the day number of the week");

    while (!int.TryParse(Console.ReadLine() , out number)|| number < 1 || number > 7)
    {
    Console.WriteLine("Input does not match the day of the week!");
    }
    return number;
}


bool IsdayOff(int a)
{
    if (a == 6 || a == 7) return true;
    else return false;
}