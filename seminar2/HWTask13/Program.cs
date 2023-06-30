// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
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
            case "13": Task1(); break;
            default:
                break;
        }
    }
}

void Task1()
{
	int number = ReadInt();
	if (number>99 || number < -99) 
	{
		Console.WriteLine(GetThirdDigit(number));
	}
	else Console.WriteLine("third digits no");
}


int GetThirdDigit(int number)
{
	while (Math.Abs(number) >=1000) number /= 10;
	int ThirdDigit = Math.Abs (number % 10);
	return ThirdDigit;
}


int ReadInt()
{
	int number;

	Console.Write($"Input number:");

	while (!int.TryParse(Console.ReadLine() , out number))
	{
		Console.WriteLine("It's not a number!");
	}

	return number;
}