//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int Num);

if (isParsed == false)
{
    Console.WriteLine("Введённые данные некорректны");
    return;
}
if (Num < 1 || Num > 7)
{
    Console.WriteLine($"{Num} дня в неделе нет!");
    return;
}
if (Num == 7 || Num == 6)
{ Console.WriteLine("Да"); }
else
{
    Console.WriteLine("Нет");
}