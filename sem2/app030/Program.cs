int size = 8;
int[] TestArray = new int[size];
Console.WriteLine(TestArray.Length);
for (int i = 0; i < TestArray.Length; i++)
{
    TestArray[i] = new Random().Next(0, 2);
}


for (int i = 0; i < TestArray.Length; i++)
{
    //Console.Write(TestArray[i]+ " ");
    Console.Write($"Vvedite element {i} - ");
    TestArray[i] = Convert.ToInt32(Console.ReadLine());
}
//int[] TestArray = new int[5] {1,2,3,4,5};