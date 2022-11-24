//Console.Clear();
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-99, 100) + new Random().NextDouble(),2);
        }
    }
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Сформирован такой массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,8}", array[i, j]));
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер N: ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[x, y];

FillArray(array);
PrintArray(array);

