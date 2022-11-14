Console.WriteLine("Возведем число А в степень Б. Введите А - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А теперь ведите Б - ");
int B = Convert.ToInt32(Console.ReadLine());
int res = A;
for (int i = 1; i < B; i++)
{
    res = res * A;
    //Console.WriteLine($"Промежут - {res}");
    //Thread.Sleep(300);
}
Console.WriteLine($"Результат - {res}");