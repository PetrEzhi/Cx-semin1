int SumMN(int M, int N)
{
    return M == N ? M : SumMN(M, N - 1) + N;
    //if (M == N) return 0;
    //else return SumMN(M, N - 1);
}
Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < N) Console.Write(SumMN(M, N));
if (M == N) Console.Write("Так они же одинаковые..");
if (M > N) Console.Write(SumMN(N, M));