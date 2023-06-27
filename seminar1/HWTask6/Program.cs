//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("введите число");

int a = 0;

if  (int.TryParse(Console.ReadLine(), out a ) ) //(int.TryParse(Console.ReadLine()) , out a ) 
{
    if (a % 2 == 0) 
    System.Console.WriteLine($"число {a} является четным");

    else System.Console.WriteLine($"число {a} не является четным");
}
else
{
    System.Console.WriteLine("число не корректно");
}