Console.WriteLine("Привет, давай проверим четность!");
Console.Write("Введи число - ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) Console.WriteLine($"Да, число {a} чётное!");
else Console.WriteLine($"Нее, число {a} нечётное!");