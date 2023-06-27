// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("введите число");

int N = 0; 

if  (int.TryParse(Console.ReadLine() , out N ) ) 
{   if (N > 0)
    {    for ( int n = 1; n <= N ;  n ++ )
        {
            if (n % 2 == 0) System.Console.Write(n + " ,");
        }
    }
    else 
    {
        for (int n2 = -1; n2 >= N ; n2 --)
        {
            if (n2 % 2 == 0) System.Console.Write(n2 + " ,");
        }
    }

}
else 
{
System.Console.WriteLine("число не корректно");
}