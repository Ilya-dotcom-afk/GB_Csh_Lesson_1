// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("введите число от 10 до 99 включительно");
double a = Convert.ToDouble(Console.ReadLine());
double b, c;
if (a <= 99 && a >= 10)
{
b = a%10;
c = (a - b)/10;
if (c>b){
Console.WriteLine(c);
}
if (c<b){
    Console.WriteLine(b);
}
if (c==b){
    Console.WriteLine("цифры равны");
}
}
else
{
    Console.WriteLine("Число не входит в заданный интервал");
}
