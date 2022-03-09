// Найти максимальное из трех чисел
Console.WriteLine("введите число а:  ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число b:  ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число c:  ");
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if (max<b)
{
max = b;
}
else if (max<c)
{
max = c;
}
Console.WriteLine("Максимальное числоЖ " + max);