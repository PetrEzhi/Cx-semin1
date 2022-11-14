
Console.WriteLine("Введите количество нужных чисел Фибоначчи");
int Num = Convert.ToInt32(Console.ReadLine());
double[] res = new double[Num];
if (Num == 0) Console.WriteLine("Ну и не будет тебе Фибоначчи");
else
{
    res[0] = 0;
    if (Num == 1) Console.WriteLine("Ну и получи свой 0");
    else
    {
        res[1] = 1;
        if (Num > 1)
        {
            for (int i = 2; i < Num; i++)
            {
                res[i] = res[i - 1] + res[i - 2];
     Console.WriteLine(res[i]); 
            }

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");                
    Thread.Sleep(100);
            }
        }
    }
}



/*
int[] GetArrayFibNumber(int number)
{
    int[] arrayFib = new int[number];
    if (number > 0)
    {
        arrayFib[0] = 0;
        if (number > 1)
        {
            arrayFib[1] = 1;
            for (int i = 2; i < arrayFib.Length; i++)
            {
                arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
            }
        }
    }
    return arrayFib;
}
*/