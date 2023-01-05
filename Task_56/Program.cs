// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();


void CreateRandomArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1,10);
        }
    }
}

void StringSearch(int[,] arr)
{
    int minLine = 0;
    int sumMinLine = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sumMinLine += arr[0, j];
    }
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumLine += arr[i, j];
        }
        if(sumMinLine > sumLine)
        {
            minLine = i;
            sumMinLine = sumLine;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшой суммой элементов: {minLine + 1}");
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write( arr[i, j] + " " );
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
CreateRandomArrey(matrix);
ShowArray(matrix);
StringSearch(matrix);