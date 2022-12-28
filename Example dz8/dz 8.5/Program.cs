// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

try
{
    int m = ReadInt("Введите m: ");
    int n = ReadInt("Введите n: ");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= m * n)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < m - 1)
            ++j;
        else if (i < j && i + j >= m - 1)
            ++i;
        else if (i >= j && i + j > m - 1)
            --j;
        else
            --i;
        ++num;
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