Console.WriteLine("Введите по очереди координаты первой точки(x,y,z). Нажмите Enter после ввода каждой из координат.");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите по очереди координаты второй точки(x,y,z). Нажмите Enter после ввода каждой из координат.");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Работаем с такими кординатами: X : {x1}, {x2}, Y : {y1}, {y2}, Z : {z1}, {z2}.");
double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние получилсоь - {result}");
Console.ReadKey();