//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

try
{
    int m = ReadInt("Введите m: ");
    int n = ReadInt("Введите n: ");
    int[,] array = Create2DArray(m, n);
    Print2DArray(array);
    double[] array2 = GetArithMeanArray(array);
    PrintArray(array2);
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

double[] GetArithMeanArray(int[,] array)
{
    double[] avgNumbers = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        double result = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        avgNumbers[i] = result / array.GetLength(0);
    }
    return avgNumbers;
}

void PrintArray(double[] array)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write("{0:f1}; ", array[i]);

    }
    Console.WriteLine();
}

