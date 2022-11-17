Console.Clear();
Console.WriteLine("Сколько строк?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов?");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

int[,] FillArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

FillArr(array);
Console.WriteLine();
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int j = i;
    sum += array[i, j];
}
Console.WriteLine(sum);