double Getdist(int x1, int y1, int x2, int y2)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
    return distance;
}

Console.WriteLine("Vvedi X1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi Y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi X2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

double dist = Getdist(x1,y1,x2,y2);
Console.WriteLine($"Rasstoyanie: {dist}");