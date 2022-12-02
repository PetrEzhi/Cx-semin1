
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
int PrintN(int N)
{
    Console.Write(N+ " ");
    if (N == 1) return 1;
    else return PrintN(N - 1);
}
PrintN(N);