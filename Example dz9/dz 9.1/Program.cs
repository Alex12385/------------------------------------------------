// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// try
// {

Console.Write("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NumberLowering(numberN);

void NumberLowering(int n, int i = 1)
{
    if (i > numberN)
    {
        return;
    }
    else
    {
        NumberLowering(n, i + 1);
        Console.Write(i + " ");
    }
}