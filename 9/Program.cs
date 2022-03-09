// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int i, b;
i = (int)Math.Log10(a) + 1;
if (i < 3)
{
    Console.WriteLine("Третьего знака в числе нет");
}
else
{
/*int c = a%((int)Math.Pow(10, (i-2)));
int d = a%((int)Math.Pow(10, (i-3)));
int e = (int)Math.Pow(10, i-3);
b = (c-d)/e;*/
b = (a%((int)Math.Pow(10, (i-2))) - a%((int)Math.Pow(10, (i-3))))/((int)Math.Pow(10, i-3));
Console.WriteLine(b);
}
