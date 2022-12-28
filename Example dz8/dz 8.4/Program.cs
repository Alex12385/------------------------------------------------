// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

try
{
    Console.WriteLine($"Введите размер массива M x N x P: ");
    int m = ReadInt("Введите m: ");
    int n = ReadInt("Введите n: ");
    int p = ReadInt("Введите p: ");

    int[,,] array = Create3DArray(m, n, p);
    Print3DArray(array);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

void Print3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] Create3DArray(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    if (array.Length > 100)
    { throw new Exception(); }

    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int number;

                do
                 {number = random.Next(10, 100);}

                while (Containts(array, number));
                array[i, j, k] = number;

            }
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

bool Containts(int[,,] array, int number)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                { return true; }

            }
        }
    }
    return false;
}
