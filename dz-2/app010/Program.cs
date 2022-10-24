Console.WriteLine("Введите трёхзначное число");
int ishodn = Convert.ToInt32(Console.ReadLine());
while (ishodn < 100 || ishodn > 999)
{
   Console.WriteLine("Не похоже на трёхзначное число.. Введите заново: "); 
 уп  ishodn = Convert.ToInt32(Console.ReadLine());
}
int preobraz = (ishodn - ((ishodn/100)*100))/10;
Console.WriteLine($"Вторая цифра это - {preobraz}");

