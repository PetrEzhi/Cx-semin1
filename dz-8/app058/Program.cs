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
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

Console.WriteLine("Введите размер M 1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер N 1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер M 1: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер N 1: ");
int y2 = Convert.ToInt32(Console.ReadLine());
if (x1 != y2)
{
    Console.WriteLine("\nКоличество столбцов первой матрицы должно быть равно количеству строк второй матрицы!");
    Console.WriteLine("Давайте сделаем их одинаковыми: ");
    x1 = Convert.ToInt32(Console.ReadLine());
    y2 = x1;
}
int[,] array2 = new int[x2, y2];
int[,] array1 = new int[x1, y1];

FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    var resar = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                resar[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resar;
}

int[,] resarr = MultiplicationMatrix(array1, array2);
PrintArray(resarr);