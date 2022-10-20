Console.Write("Vvedi A - ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedi B - ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Vvedi C - ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max= b;
if (c > max) max= c;
Console.WriteLine($"Max eto - {max}");