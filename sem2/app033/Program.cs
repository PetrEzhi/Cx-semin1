int[] array = new int[19];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    //Console.Write(array[i] + " ");
}

void Search(int[] array, int Num)
{
    bool find = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num)
        {
            find = true;
        }
    }
    if (find == true)
        Console.Write("Число есть!");
    else
        Console.Write("Числа нет!");
}

Console.WriteLine("Введите искомое число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Search(array, Num);