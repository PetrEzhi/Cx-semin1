Console.WriteLine("Введите число - ");
int a = Convert.ToInt32(Console.ReadLine());
string stra = Convert.ToString(a);
int res = 0;
for(int i = 0; i < stra.Length; i++)
{
    res = res + (a % 10);
    a = a/10;
    //Console.Write($"Промеж {res}");
    //Thread.Sleep(300);
}
Console.WriteLine($"Сумма цифр числа '{stra}' это - '{res}'");