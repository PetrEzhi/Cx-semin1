Console.Write("Введи число - ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 2;
string reslt = ("");
int count = 0;
if (n > 4)
{
while (a < n)
    {
    reslt = reslt + a + ", ";
    a = a + 2;
    count++;
    }
}
else 
reslt = ($"{a}");
/* 
if (reslt[count*3] == ',')
{
    reslt[count*3] = ' ';
}
*/
Console.Write(reslt);