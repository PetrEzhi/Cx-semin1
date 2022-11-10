int[] array = new int[123];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 999);
    Console.Write(array[i] + " ");
}

int Count(int[] array, int a1, int a2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>a1 && array[i]<a2)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите искомое меньшее число(например 10): ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое меньшее число(например 99): ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество нужных нам элементов = {Count(array, a1, a2)}");

