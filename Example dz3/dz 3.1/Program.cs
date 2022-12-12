//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (isParsed == false)
{
    Console.WriteLine("Введённые данные некорректны");
    return;
}

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введённое число не пятизначное");
    return;
}

int num1 = num / 10000;
int num2 = (num / 1000) % 10;
int num3 = (num / 10) % 10;
int num4 = num % 10;
if (num1 == num4 && num2 == num3)
{ Console.WriteLine($"число {num} является палиндромом"); }
else
{
    Console.WriteLine($"число {num} не является палиндромом");
}

