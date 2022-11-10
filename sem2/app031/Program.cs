
int[] array = new int[12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    Console.Write(array[i] + " ");
}

int sumpos = 0;
int sumneg = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
	sumpos = sumpos +array[i];
    else
	sumneg = sumneg +array[i];

}


Console.WriteLine($"  Получилось {sumpos} и {sumneg}");