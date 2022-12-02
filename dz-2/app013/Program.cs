﻿Console.WriteLine("Выведу вам 3ю цифру в числе. Введите число");
int absol = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (absol < 100)
{
   Console.WriteLine("Третьей цифры в этом числе нет!"); 
}
else
{
    string preobraz = Convert.ToString(absol);
    Console.WriteLine($"Третья цифра это - {preobraz[2]}");
}