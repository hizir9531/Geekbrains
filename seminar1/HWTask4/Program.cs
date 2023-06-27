// Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

 System.Console.WriteLine("введите три числа");

int a = 0; 
int b = 0 ;
int c = 0 ;
int MaxNumber = 0;

if  ( int.TryParse(Console.ReadLine(), out a ) && int.TryParse(Console.ReadLine() , out b) && int.TryParse(Console.ReadLine() , out c))
{
    if ( a > b ) MaxNumber = a;

    else MaxNumber = b;

    if ( MaxNumber > c ) ;

    else MaxNumber = c;
    
    System.Console.WriteLine($" максимальное число {MaxNumber}");
}   
else
System.Console.WriteLine("не все числа корректны");    