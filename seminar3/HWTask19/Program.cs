// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

main();

void main()
{
    bool isWorking = true;

    while (isWorking)
    {
        Console.WriteLine("введите <пуск> для запуска или <выход> для завершения: ");
        string task = Console.ReadLine();
        switch (task)
        {
            case "выход": isWorking = false; break;
            case "пуск": task19(); break;
            default:
                break;
        }
    }
}


int ReadInt()
{
	int number;

	Console.WriteLine($"введите пятизначное число:");

	while (!int.TryParse(Console.ReadLine() , out number)|| number/10000 == 0 || Math.Abs(number/10000)>=10)
	{
		Console.WriteLine("число не пятизначное, повторите ввод:");
	}
	return number;
}


void task19()
{
    if (IsPalindrom()) Console.WriteLine($"да");  
    else Console.WriteLine($"нет");
}


bool IsPalindrom()
{
    int number= ReadInt();
    int length = GetLength(number);
    for (int i = 1; i<=(length/2); i++)
        {    
            if (number < 0 ||(GetDigit(i,number) != GetDigit(length-(i-1),number))) return false;

        }
    return true;
    
}

int GetLength(int num)
{   
    int n =0;
    for(;num != 0;n++) num /= 10;
    return n;
}



int GetDigit(int n,int number)
{
    for (int i=1;i<n;i++) number /= 10;
    int d = number% 10;
    return d;
}
 