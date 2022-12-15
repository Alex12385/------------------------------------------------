//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.WriteLine("Введите первое число: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = double.Parse(Console.ReadLine());
double result = GetExponentiation(num1, num2);

if (num2 < 0)
{
    double res = 1 / result;
    string result1 = string.Format("{0:f4}", res);
    Console.WriteLine(result1);
}
else
{ Console.WriteLine(result); }

double GetExponentiation(double a, double b)
{
    double exp = 1;
    for (double i = 1; i <= b; i++)

    { exp = exp * a; }

    return exp;
}