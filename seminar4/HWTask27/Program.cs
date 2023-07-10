
int ReadInt()
{
	int number;

	Console.WriteLine($"введите число:");

	while (!int.TryParse(Console.ReadLine() , out number))
	{
		Console.WriteLine("число не корректно, повторите ввод:");
	}
	return number;
}

int number = ReadInt();
int result = 0;
while (number/10 != 0)
{
    result=result+number%10;
    number= number/10;
}
result=result+number%10;
System.Console.WriteLine($"  -> {result}:");