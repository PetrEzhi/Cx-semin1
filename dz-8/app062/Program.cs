void FillArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= array.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > array.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}
void WriteArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}

Console.Write("Квадратный двумерный массива какого размера делаем: ");
int x = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[x, x];
FillArray(array);
Console.WriteLine("Получился вот такой массив:");
WriteArray(array);