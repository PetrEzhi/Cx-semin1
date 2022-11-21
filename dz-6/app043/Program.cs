// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Davai naydem tochku peresechenia 2 pramih tipa 'y = k*x + b'");
double[] EnterParams()
{
    double[] a = new double[4];
    Console.Write("Vvedi k1: ");
    a[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Vvedi b1: ");
    a[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Vvedi k2: ");
    a[2] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Vvedi b2: ");
    a[3] = Convert.ToDouble(Console.ReadLine());
    /*Console.WriteLine($"Okey, davay naydem tochku peresechenia pryamih 'y = {a[0]}*x + {a[1]}' i 'y = {a[2]}*x + {a[3]}'");
    Console.Write("Schitayu");
    for (int i = 0; i < 8; i++)
    {
        Thread.Sleep(300);
        Console.Write(".");
    }
    Console.WriteLine();*/
    return a;
}
double[] arr = EnterParams();
while (arr[0] == arr[2])
{
    if (arr[1] == arr[3])
    {
        Console.WriteLine("Eto zhe odna i ta ze pramaya poluchilas! Vvedi raznie.");
        arr = EnterParams();
    }
    else
    {
        Console.WriteLine("Eti dve pramie ze parallelni. Vvedi raznie 'K'.");
        arr = EnterParams();
    }
}
double x = (arr[3] - arr[1]) / (arr[0] - arr[1]);
double y = arr[0] * x + arr[1];
Console.WriteLine($"Tochka peresechenia poluchetsa takaya: x = {x} i y = {y}");
