Console.WriteLine("Введите пожалуйста 8 значений для массиваа поочередно:");
int [] array = new int [8];
for(int i = 0; i < 8; i++)
{
    int temp = i+1;
    Console.WriteLine($"Введите число {temp} - ");
    array[i]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вы ввели массив:");
for(int i = 0; i < 8; i++)
{
    Console.Write(array[i] + " ");
}
