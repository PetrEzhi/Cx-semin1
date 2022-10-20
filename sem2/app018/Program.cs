string GetCoordArea(int chetvert)
{
    string coords = "";
    if (chetvert == 1) coords = "x > 0, y > 0";
    if (chetvert == 2) coords = "x < 0, y > 0";
    if (chetvert == 3) coords = "x < 0, y < 0";
    if (chetvert == 4) coords = "x > 0, y < 0";
    return coords;
}

bool IsTrue = true;
string input = "a";
Console.WriteLine("Vvedi nomer chetverti ");
input = Console.ReadLine();
IsTrue = int.TryParse(input, out int n);
while (IsTrue == false || n < 1 || n > 4) 
{
    Console.WriteLine(n);
    Console.WriteLine("Ti vvel kakuuto fignu");
    Console.WriteLine("Vvedi normalniy nomer chetverti! ");
    input = Console.ReadLine();
    IsTrue = int.TryParse(input, out n);
}
string coords = GetCoordArea(n);
    Console.WriteLine($"Vozmozhnie coordinati: {coords}");

/*
string GetCoordArea(int chetvert)
{
    string coords = "";
    if (chetvert == 1) coords = "x > 0, y > 0";
    if (chetvert == 2) coords = "x < 0, y > 0";
    if (chetvert == 3) coords = "x < 0, y < 0";
    if (chetvert == 4) coords = "x > 0, y < 0";
    return coords;
}

Console.WriteLine("Vvedi nomer chetverti ");
int n = Convert.ToInt32(Console.ReadLine());

string coords = GetCoordArea(n);
Console.WriteLine($"Vozmozhnie coordinati: {coords}");
*/
