// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int numberN = int.Parse(Console.ReadLine());
int sum = 0;
SumElementsFromMToN(numberM, numberN, sum);

void SumElementsFromMToN(int m, int n, int sum)
{
     if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    SumElementsFromMToN(m, n, sum);
}