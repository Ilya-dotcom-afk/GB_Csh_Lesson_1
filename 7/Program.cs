// Удалить вторую цифру трёхзначного числа
Console.WriteLine("введите трёхзначное число");
double a = Convert.ToDouble(Console.ReadLine());
double b, d;
if (a>99 && a<1000)
{
b = a%10;
d = (a - a%100)/100;
Console.WriteLine(d*10+b);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}
