// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Console.Clear();
Console.Write("Skolko chisel vvedete? ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Vvedite chislo {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}
int coun = CountPositiveNumbers(array);
Console.WriteLine($"Vi vveli '{coun}' polozhit chisel");

Console.Write("Введите элементы (через пробел) :  ");
int[] array2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i]+", ");
}
    Console.WriteLine();
    Console.WriteLine(array2[0]+array2[2]);
