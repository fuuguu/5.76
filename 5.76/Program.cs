//Голубихин Данила 22-ИСП-2/2 Задание 5.76
Console.Write("Введите а: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
double b = 1;
for(int i = 1; i <= n; i++)
{
    b *= a;
    Console.WriteLine(b);
}
