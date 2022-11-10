int NumLengt(int number)
{
    string strNum = Math.Abs(number).ToString();
    int length = strNum.Length;
    return length;
}

Console.Write("Vvedite chislo A : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumLengt(number));
