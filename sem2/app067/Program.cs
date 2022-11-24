/*int NaturalNumbers(int n, int sum)
{
    sum = sum + n % 10;
    if (n < 1)
    {
        return sum;
    }
    return NaturalNumbers(n / 10, sum);
}
Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = NaturalNumbers(n, 0);
Console.Write(result);
---------------------------------------------*/
Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumRec(int number, int currentSum)
{
if (number > 9) 
{
    currentSum+=number%10;
    return SumRec(number/10, currentSum);
}
else return currentSum+number;
}
Console.WriteLine(SumRec(number, 0));

