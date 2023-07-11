//Задайте одномерный массив , заполненный случайными числами.
//Найдите сумму элементов , стоящих на нечетных позициях.

int ReadInt(string text)
{
	int number;

	Console.WriteLine($"{text}");

	while (!int.TryParse(Console.ReadLine() , out number))
	{
		Console.WriteLine("число не корректно, повторите ввод:");
	}
	return number;
}

int L()
{
    int length = 0;
    length = ReadInt("введите длинну массива");
    if ( length <= 0)
    {
        Console.WriteLine("длинна массива не корректна, повторите ввод:");
        return L();
    }
    else return length;
}
int length = L();
int sum = 0;
int[] N = new int[length];
Console.Write("[");
for (int i = 0; i < length; i++)
{
    N[i] = new Random().Next(100, 1000);
    Console.Write(N[i] + ";");
    if (i%2 != 0)
    sum=sum+N[i];
}
Console.Write("]");
Console.WriteLine($" -> сумма чисел на нечетных позициях: {sum}");