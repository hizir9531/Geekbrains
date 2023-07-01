/// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


main();

void main()
{
    bool isWorking = true;

    while (isWorking)
    {
        Console.WriteLine("введите <go> для запуска или <exit> для завершения: ");
        string task = Console.ReadLine();
        switch (task)
        {
            case "exit": isWorking = false; break;
            case "go": Cubed(ReadInt()); break;
            default:
                break;
        }
    }
}

int ReadInt()
{
	int number;

	Console.WriteLine($"введите число:");

	while (!int.TryParse(Console.ReadLine() , out number))
	{
		Console.WriteLine("не является числом , повторите ввод:");
	}
	return number;
}

void Cubed(int num)
{
     Console.Write($"{num}->");
    for (int i=1;i<=num;i++)
    {
        Console.Write($" {Math.Pow(i,3)},");
    }
	Console.WriteLine("");
}