// Пишем метод обработки массива
int CountEven(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2==0) count++;
    }
   return count;
}
//Создаем массив
Console.Write($"Kakuyu dlinu massiva hotite? ");
int leng = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[leng];
//Console.WriteLine($"Dlina massiva - {leng}");
for (int i = 0; i < leng; i++)
{
    arr[i] = new Random().Next(100, 1000);
    //Console.Write(arr[i]+" ");
}
//Вызываем метод и обрабатываем
int evencount = CountEven(arr);
Console.WriteLine($"V sgenerirovanom massive '{evencount}' chetnih chisel");