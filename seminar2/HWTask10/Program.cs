// task10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// main();
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
            case "10": task1(); break;
            default:
                break;
        }
    }
}



int ReadInt()
{
	int number;

	Console.WriteLine($"Input three-digit number");

	while (!int.TryParse(Console.ReadLine() , out number)|| number/100 == 0 || Math.Abs(number/100)>=10)
	{
		Console.WriteLine("It's not a three-digit number!");
	}
	return number;
}

void task1()
{
	int ThreeDigitNumber = ReadInt();
	Console.WriteLine(WithdrawNumber(ThreeDigitNumber));
} 

int WithdrawNumber(int a)
{
	int FirstNumber = a/100;
	int SecondDigit = ( a / 10)-( FirstNumber *10) ;
	return SecondDigit;
}