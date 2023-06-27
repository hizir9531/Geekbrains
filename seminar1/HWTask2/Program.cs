// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("введите два числа");

int a = 0; 
int b = 0 ;

if  (int.TryParse(Console.ReadLine(), out a ) && int.TryParse(Console.ReadLine() , out b))
{
    if ( a == b )
    System.Console.WriteLine("числа равны");
    
    else if ( a > b )
    System.Console.WriteLine($" {a} большее число ; {b} меньшее число") ;
    
    else 
    System.Console.WriteLine($" {b} большее число ; {a} меньшее число") ;
}   
else
System.Console.WriteLine("не корректный ввод");