int GetFactorial(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res = res * i;
        Thread.Sleep(300);
        Console.WriteLine($"Результат итерации {i} равен {res}");
    }
    Thread.Sleep(300);
    return res;
}

Console.Write("Vvedite chislo A : ");
int number = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(300);
Console.WriteLine($"Приняли число : {number}");
Thread.Sleep(300);
Console.WriteLine($"Rusult is : {GetFactorial(number)}");
