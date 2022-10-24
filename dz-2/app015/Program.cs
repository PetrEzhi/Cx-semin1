Console.WriteLine("Выходной ли сегодня? Введи номер сегодняшнего дня недели");
int den = Convert.ToInt32(Console.ReadLine());
while (den < 1 || den > 7)
{
    Console.WriteLine("Что-то не то ввёл, давай ещй раз:"); 
    den = Convert.ToInt32(Console.ReadLine());
}
if (den == 1) Console.WriteLine("Сегодня понедельник!");
if (den == 2) Console.WriteLine("Сегодня вторник!");
if (den == 3) Console.WriteLine("Сегодня среда!");
if (den == 4) Console.WriteLine("Сегодня четверг!");
if (den == 5) Console.WriteLine("Сегодня пятница!");
if (den == 6) Console.WriteLine("Сегодня суббота!");
if (den == 7) Console.WriteLine("Сегодня воскресенье!");