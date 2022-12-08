//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int Num);
int count = Num.ToString().Length;

if (isParsed == false)
{
    Console.WriteLine("Введённые данные некорректны");
    return;
}

if (count < 3 || count > 3)
{
    Console.WriteLine("Введённое число не трёхзначное");

}
else
{
    int firstDigit = Num % 100;
    int middleDigit = firstDigit / 10;
    Console.WriteLine(middleDigit);
}
