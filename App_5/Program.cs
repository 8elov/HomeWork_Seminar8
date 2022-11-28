// Заполните спирально массив 4 на 4.

int[,] array = new int[4, 4];

FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = number;
        number++;
        if ((i <= j + 1) && (i + j < array.GetLength(1) - 1))
        {
            j++;
        }    
        else if ((i < j) && (i + j >= array.GetLength(0) - 1))
        {
            i++;
        }
        else if ((i >= j) && (i + j > array.GetLength(1) - 1))
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine();
    }
}

