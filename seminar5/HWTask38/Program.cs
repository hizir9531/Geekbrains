// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива

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
double min=1000;
double max=0;
int length = L();
double[] N = new double[length];
Console.Write("[");
for (int i = 0; i < length; i++)
{
    N[i] = Math.Round( new Random().NextDouble()* new Random().Next(1,11),2);
    Console.Write(N[i] + ";");
    if (N[i] > max) max=N[i];
    if (N[i]< min) min=N[i];
}
double result = max-min;
Console.WriteLine($"]  Разница между максимальным и минимальным элементом: {result}");