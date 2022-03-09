// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число, проеряемое на кратность");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кратность");
double b = Convert.ToDouble(Console.ReadLine());
if (a%b != 0){
Console.WriteLine("число " + a + " не кратно числу " + b + " остаток от деления равен " + a%b);
}
else{
    Console.WriteLine("число " + a + " нацело делится на " + b);
}