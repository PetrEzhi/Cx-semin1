int Getsumm(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Vvedite chislo A : ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Getsumm(number);
Console.WriteLine(sum);
