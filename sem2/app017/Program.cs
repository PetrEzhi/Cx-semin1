int GetPointArea(int coordX, int coordY)
{
    int numberarea = 0;
    if (coordX > 0 && coordY > 0) numberarea = 1;
    if (coordX < 0 && coordY > 0) numberarea = 2;
    if (coordX < 0 && coordY < 0) numberarea = 3;
    if (coordX > 0 && coordY < 0) numberarea = 4;
    return numberarea;
}

Console.WriteLine("Vvedi X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedi Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberarea = GetPointArea(x,y);
Console.WriteLine($"Chetvert: {numberarea}");