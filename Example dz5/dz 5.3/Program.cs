// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] number = new double[size];
DifferenceBetweenMaxMin(number);

double DifferenceBetweenMaxMin(double[] number)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    double result = 0;

    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }

    for (int a = 0; a < number.Length; a++)
    {
        if (number[a] > max)
        {
            max = number[a];
        }
        if (number[a] < min)
        {
            min = number[a];
        }

    }

    string str = string.Join(", ", number);
    Console.WriteLine($"Ваш массив: [{str}]");
    Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
    result = max - min;
    Console.WriteLine($"Разность между максимальным и минимальным = {result}");
    return result;
}


