Console.Clear();
Console.Write("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
while(n > 100)
 n=n / 10;
Console.Write(n % 10);
