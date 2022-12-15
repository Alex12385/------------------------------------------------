//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = GetSumOfNumbers(num);
Console.WriteLine(result);

int GetSumOfNumbers(int a)
{
    int sum = 0;
    while (a > 0)
    {
        int r = a % 10;
        a = a / 10;
        sum = sum + r;

    }

    return sum;
}