
Console.WriteLine("Кубы от 1 до какого целого числа вам вывести?");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
string result = ("1");

while (count < n)
{
    count++;
    result = result +", "+ (count*count*count);
}

Console.WriteLine($"Полученные кубы: {result}");