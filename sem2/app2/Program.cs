int number = new Random().Next(10,100);
int a1 = number/10;
int a2 = number % 10;
if (a1 > a2) Console.WriteLine($"Bolshee {a1}");
if (a2 > a1) Console.WriteLine($"Bolshee {a2}");
if (a1 == a2) Console.WriteLine($"Oni odinakovi");
Console.WriteLine(number);
//Console.ReadKey();