//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] arr = GetCubeOfNumbers(num);
PrintArray(arr);

int[] GetCubeOfNumbers(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    { array[i] = (i + 1) * (i + 1) * (i + 1); }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
