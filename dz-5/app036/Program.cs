//Sozdali i zapolnili
int[] mas = new int[10];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(-123, 456);
    //Console.Write(mas[i]+" ");
}
//Teper pognali schitat nechetn pozicii
Console.WriteLine();
int sum = 0;
int nech = 1;
while (nech < mas.Length)
{
    sum = sum + mas[nech];
    nech=nech+2;
    //Console.Write(sum+" ");
}
Console.WriteLine($"Summa nechetn elementov massiva: {sum}");