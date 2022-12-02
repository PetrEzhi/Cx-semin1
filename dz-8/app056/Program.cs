void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.WriteLine("Введите размер M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер N: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[x, y];

FillArray(array);
PrintArray(array);
Console.WriteLine("А теперь строку с наименьшей суммой");

int sum1 = 0;
int sum2 = 0;
int pos = 0;
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum1 = sum1 + array[i, j];
        }
        if (sum1 > sum2)
        {
          sum1 = sum2;
          pos = i+1;
        }
    }
}
Console.WriteLine($"Cтрокa с наименьшей суммой - {pos}");


