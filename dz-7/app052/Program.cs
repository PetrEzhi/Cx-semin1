//Console.Clear();
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-99, 100) + new Random().NextDouble(), 2);
        }
    }
}
/*void PrintArray(double[,] array)
{
    Console.WriteLine("Был сформирован массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,8}", array[i, j]));
        }
        Console.WriteLine();
    }
}*/
void AverageLine(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        Console.Write(Math.Round((sum / array.GetLength(1)), 3) + "  ");
    }
}

Console.WriteLine("Введите размер M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер N: ");
int y = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[x, y];
FillArray(array);
//PrintArray(array);
AverageLine(array);


