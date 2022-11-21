Console.WriteLine("Введите M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    Console.WriteLine("Был сформирован массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}
if (x != y || x == 0 || y == 0)
{
    Console.WriteLine("Массив такого размера не пойдет");
}
else
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(String.Format("{0,3}", array[i, j]));
        }
        Console.WriteLine();
    }
    int[,] resarr = ChangeArray(array);
    Console.WriteLine("Result: ");
    for (int i = 0; i < resarr.GetLength(0); i++)
    {
        for (int j = 0; j < resarr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", resarr[i, j]));
        }
        Console.WriteLine();
    }
}