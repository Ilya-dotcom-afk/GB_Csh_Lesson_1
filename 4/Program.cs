// Показать последнюю цифру трёхзначного числа
Console.WriteLine("введите трёхзначное число");
double a = Convert.ToDouble(Console.ReadLine());
double b;
if (a>99 && a<1000)
{
b = a%10;
Console.WriteLine(b);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}