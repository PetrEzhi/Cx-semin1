﻿
Console.Write("Vvedi chislo - ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Kratno! Vvel horoshee chislo!");
}
else
{
        Console.WriteLine("Ne kratno! Vvel plohoe chislo!");
}