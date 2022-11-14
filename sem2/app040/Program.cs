
Console.WriteLine("Введите три положительных числа. А -");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B -");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("C -");
int c = Convert.ToInt32(Console.ReadLine());

bool IsTriangle (int a, int b, int c)
{
 if (a < b+c)
 {
    if (b < a+c)
    {
        if (c < a+b)
        {
            return true;
        }
        else return false;
    }
    else return false;
 }
 else return false;
}

 Console.WriteLine(IsTriangle(a, b ,c));

 