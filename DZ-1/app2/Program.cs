Console.WriteLine("Привет, мне нужны два разных числа!");
Console.Write("Введи первое - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе - ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine($"Стоп! Ты зачем ввел два одинаковых числа?");
    Console.WriteLine("Давай по новой и введи два действительно разных числа!");
    Console.Write("Введи первое - ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введи второе - ");
    b = Convert.ToInt32(Console.ReadLine());
}
if (a > b) 
{
    Console.WriteLine($"Наибольшее - {a}, a наименьшее {b}");
}
if (a < b) 
{
    Console.WriteLine($"Наибольшее - {b}, a наименьшее {a}");
}
if (a == b)
{
    Console.WriteLine($"Эм, ты опять ввёл два одинаковых числа? Я ухожу..");
}