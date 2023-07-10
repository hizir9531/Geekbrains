
int[]array={1,2,3,4,5,6,7,8,9};
int start=0;
int end = 8;
int sought = 6;
int middle = 0;
//int end = aray.length;
// int ReadInt()
// {
// 	int sought;

// 	Console.WriteLine($"Введите искомое число");

//     while (!int.TryParse(Console.ReadLine() , out sought))
// 	{
// 		Console.WriteLine("не корректное число");
// 	}
// 	return sought;
// }

//int search(int start,int end, int sought)
//{
    while (end == start)
    {
        middle = ((end+start)/2);
        if (array[middle]<sought)
        {
            start=middle;
        }
        else end=middle;
    }
//}

//result = search(start,end,readint());
System.Console.WriteLine($" элемент находится на позиции {end}");

//Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


// int[] N = new int[123];
// int B = 0;
// for (int i=0; i < N.Length; i++) 
// {
    
//     N[i] = new Random().Next(-200, 200); 
//     if(N[i]>= 10 && N[i] <= 99)
//     {
//         B++;
//     }
//     Console.Write(N[i] + ";");
// }
// Console.WriteLine();
// Console.WriteLine($"Количество элементов: {B}");




