//Console.Clear();
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-99, 100) + new Random().NextDouble(), 4);
        }
    }
}

double[,] array = new double[5, 5];
FillArray(array);

Console.WriteLine("Введите координату M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату N: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x < 0 || y < 0) Console.WriteLine("Ввели чтото не то..");
else
{
    if (x + 1 < array.GetLength(0) && y + 1 < array.GetLength(1))
    {
        Console.WriteLine($"По введенным координатам находится вот такое значение - {array[x, y]}");
    }
    else
    {
        Console.WriteLine($"В массиве отсутствует элемент в такой позиции!");
    }
}
