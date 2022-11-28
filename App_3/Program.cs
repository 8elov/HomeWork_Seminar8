// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m,n];
int[,] array2 = new int[m,n];
int[,] arrayResult = new int[m,n];

FillArray(array1);
Console.WriteLine("Первая матрица:");
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
Console.WriteLine("Вторая матрица:");
PrintArray(array2);
Console.WriteLine();
MatrixProduct(array1,array2);
Console.WriteLine("Произведение двух матриц:");
PrintArray(arrayResult);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void MatrixProduct(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                arrayResult[i, j] += (array1[i, k] * array2[k, j]);
            }
        }
    }
}
