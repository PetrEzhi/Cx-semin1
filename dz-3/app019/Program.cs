Console.WriteLine("Введите 5значное число, проверю зеркальность");
int ishodn = Convert.ToInt32(Console.ReadLine());
int absol = Math.Abs(ishodn);
while (absol < 10000 || absol > 99999)
{
   Console.WriteLine("Ввёл не то что-то, давай ещё раз");  
   ishodn = Convert.ToInt32(Console.ReadLine());
   absol = Math.Abs(ishodn);
}
string preobraz = Convert.ToString(absol);
if (preobraz[0] == preobraz[4])
{
    if (preobraz[1] == preobraz[3])
    {
        Console.WriteLine($"Да, число {ishodn} зеркальное!");
    }
}
else
{Console.WriteLine($"Нет, число {ishodn} не является зеркальным!");}
