// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

try
{
    int m = ReadInt("Задайте количество строк в массиве: ");
    int n = ReadInt("Задайте количество столбцов в массиве: ");
    int row = ReadInt("Введите индекс строки: ");
    int col = ReadInt("Введите индекс столбца: ");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);

    if (row < 0 | row > array.GetLength(0) - 1 | col < 0 | col > array.GetLength(1) - 1)
    {
        Console.WriteLine($"{row}{col} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[row - 1, col - 1]);
    }


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

int ReadInt(string title)
{
    Console.Write(title);

    bool isParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isParsed)
    {
        return number;
    }

    throw new Exception("Введены не корректные символы");
}
