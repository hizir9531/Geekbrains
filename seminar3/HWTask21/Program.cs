// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



int Read(string coordinate)
{
    System.Console.WriteLine($"Введите {coordinate}:");
    int x = int.Parse(Console.ReadLine());
    return x;
}

int x1 = Read("x1");
int y1 = Read("y1");
int z1 = Read("z1");
int x2 = Read("x2");
int y2 = Read("y2");
int z2 = Read("z2");

double differenceSquare(int a, int b)
{
double C = Math.Pow((a - b),2);
return C;
}

double AB = Math.Sqrt(differenceSquare(x1,x2) + differenceSquare(y1,y2) + differenceSquare(z1,z2));

System.Console.WriteLine($"Длина отрезка: {Math.Round(AB,2)}");


