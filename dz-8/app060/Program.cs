void FillArray(int[,,] array)
{
    int[] posledov = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number = 0;
    for (int i = 0; i < posledov.GetLength(0); i++)
    {
        posledov[i] = new Random().Next(10, 100);
        number = posledov[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (posledov[i] == posledov[j])
                {
                    posledov[i] = new Random().Next(10, 100);
                    j = 0;
                    number = posledov[i];
                }
                number = posledov[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = posledov[count];
                count++;
            }
        }
    }
}

void WriteArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $" ({i},{j},{k})" + $"   ");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("Введите 1й размер трехмерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2й размер трехмерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3й размер трехмерного массива: ");
int p = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m, n, p];

Console.WriteLine("Получили такой трехмерный массив неповторяющихся чисел:");
FillArray(array);
WriteArray(array);