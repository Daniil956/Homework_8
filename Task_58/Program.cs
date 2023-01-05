// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void CreateRandomArrey(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-9, 10);
        }
    }
}

void MultOfElements(int[,]first, int [,] second, int [,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            int sum = 0;
            sum += first[i, j] * second[i, j];
            product[i, j] = sum; 

        }
    }
}

void ShowArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


int[,] firstMatrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
CreateRandomArrey(firstMatrix);
CreateRandomArrey(secondMatrix);

ShowArray(firstMatrix);

System.Console.WriteLine();

ShowArray(secondMatrix);

int [,] multipMatrix = new int [2, 2];
MultOfElements(firstMatrix, secondMatrix, multipMatrix);

System.Console.WriteLine();

ShowArray(multipMatrix);
