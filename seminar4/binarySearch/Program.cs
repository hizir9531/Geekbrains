
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




