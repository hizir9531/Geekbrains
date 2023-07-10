//Напишите программу, которая принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В

int ReadInt()
{
	int number;

	Console.WriteLine($"введите число,возводимое в степень:");

	while (!int.TryParse(Console.ReadLine() , out number))
	{
		Console.WriteLine("число не корректно, повторите ввод:");
	}
	return number;
}
int ReadIntDegree()
{
	int number;

	Console.WriteLine($"введите натуральную степень числа:");

	while (!int.TryParse(Console.ReadLine() , out number)|| number < 0)
	{
		Console.WriteLine("данные не корректны, повторите ввод:");
	}
	return number;
}
int A = ReadInt();
int B = ReadIntDegree();
double result = Math.Pow(A,B);
System.Console.WriteLine($" {A},{B} -> {result}:");
