//Sozdali i zapolnili
double[] array = new double[new Random().Next(5, 50)];
double summ=0;
for (int i = 0; i < array.Length; i++)
{
    //array[i] = Convert.ToDouble(new Random().Next(-999, 999) * new Random().NextDouble());
    array[i] = Convert.ToDouble(new Random().Next(-999, 999) + new Random().NextDouble());
    //Console.Write(array[i] + " ");
    summ = summ + array[i];
}
//Teper delaem metod vozvrash min i max v odnom massive
double[] MinMax(double[] ar)
{
    double[] minmax = new double[2];
    double min = 0;
    double max = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] > max)
        {
            max = ar[i];
            //Console.Write(max + " ");
        }
        if (ar[i] < min)
        {
            min = ar[i];
            //Console.Write(min + " ");
        }
    }
    minmax[0] = min;
    minmax[1] = max;
    return minmax;
}

double[] mm = MinMax(array);
Console.WriteLine($"V sgenerirovannom massive({array.Length} elementov) veshestvennih chisel granichnie znachenia takie:");
Console.WriteLine($"Min = {mm[0]}");
Console.WriteLine($"Max = {mm[1]}");