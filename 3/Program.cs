// Выяснить является ли число чётным
Console.WriteLine("введите число");
double a = Convert.ToDouble(Console.ReadLine());
if (a%2 == 0)
{
   Console.WriteLine("число " + a + " чётное"); 
}
else
{
    Console.WriteLine("число " + a + " нечётное");
}
