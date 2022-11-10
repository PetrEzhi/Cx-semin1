
int[] array = new int[9] {1,-2,3,-4,5,-6,7,-8,9};

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i]+ " ");
}