// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
Console.Write("Enter A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());
int Pow(int A, int B)
{
    //return B == 0 ? 1 : Pow(A, B - 1) * A;
    if (B == 0) return 1;
    else return Pow(A, B - 1) * A;
}
Console.WriteLine(Pow(A, B));