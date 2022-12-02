int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m <= 0)
{
    Console.WriteLine("M не может быть меньше нуля. Введите заново.");
    m = Convert.ToInt32(Console.ReadLine());
}
while (n <= 0)
{
    Console.WriteLine("N не может быть меньше нуля. Введите заново.");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Значение функции Аккермана равно - {Akkerman(m, n)}");