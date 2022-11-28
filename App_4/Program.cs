// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите K: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = new int[m, n, k];
FillArray(array);

void FillArray(int[,,] array)
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    
    tempArray[0] = new Random().Next(10, 100);

    for (int i = 1; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(10, 100);

        for (int j = 0; j <= i - 1; j++)
        {
            if (tempArray[i] == tempArray[j])
            {
                tempArray[i] = new Random().Next(10, 100);
                j = 0;
            }
        }
    }

    int x = 0;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                while (array[a, b, c] == 0)
                {
                    array[a, b, c] = tempArray[x];
                    x++;
                }
                Console.WriteLine("Элемент под номером [" + a + ", " + b + ", " + c + "] = " + array[a, b, c]);
            }
        }
    }
}
