int[] array = new int[new Random().Next(5, 19)];

Console.WriteLine($"Dlina стар maasiva - {array.Length}");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
Console.WriteLine("А теперь результат:");

int lenght2 = 1;
if (array.Length % 2 == 0)
    lenght2 = (array.Length / 2);
else
{
    lenght2 = (array.Length / 2 + 1);
}
int[] array2 = new int[lenght2];
Console.WriteLine($"Dlina nov maasiva - {array2.Length}");

int ai = array.Length - 1;
for (int i = 0; i < lenght2; i++)
{
    if (i == ai)
    {
        array2[i] = array[i];
    }
    else
    {
        array2[i] = array[i] * array[ai];
        ai = ai - 1;
    }
    Console.Write(array2[i] + " ");
}
