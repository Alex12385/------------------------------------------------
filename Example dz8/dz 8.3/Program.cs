// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


try
{
    int m = ReadInt("Задайте количество строк первой матрицы: ");
    int n = ReadInt("Задайте количество столбцов первой матрицы: ");
    int[,] firstArray = Create2DArray(m, n);
    int p = ReadInt("Задайте количество строк второй матрицы: ");
    int q = ReadInt("Задайте количество столбцов второй матрицы: ");
    int[,] secondArray = Create2DArray(p, q);
    int[,] resultArray = new int[m, q];

    Print2DArray(firstArray);
    Console.WriteLine();
    Print2DArray(secondArray);
    Console.WriteLine();
    if (firstArray.GetLength(1) != secondArray.GetLength(0))
    {
        Console.WriteLine("Нельзя перемножить, количество столбцов в первой матрице должно быть равно количеству строк во второй!");
    }
    else
    {
        MultiplyArrays(firstArray, secondArray, resultArray);
        Console.WriteLine($"Произведение первой и второй матриц:");
        Print2DArray(resultArray);
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


int[,] MultiplyArrays(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return resultArray;
}