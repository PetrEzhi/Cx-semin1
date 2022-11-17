// See https://aka.ms/new-console-template for more information
Console.WriteLine("Сколько строк?");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов?");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i + j;
        Console.Write(array[i, j]);
    }
    Console.WriteLine();
}
