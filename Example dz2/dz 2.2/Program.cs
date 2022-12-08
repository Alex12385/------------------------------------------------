//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int Num);

if (isParsed == false)
{
    Console.WriteLine("Введённые данные некорректны");
    return;
}

if (Num < 100)
{
    Console.WriteLine("В ведённом числе третьей цифры нет");
    return;
}

if (Num > 999)
{
    while (Num > 999)
    {
        Num = Num / 10;
    }
    Console.WriteLine(Num % 10);
}
else
{
    Console.WriteLine(Num % 10);
}