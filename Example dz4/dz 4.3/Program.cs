// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine());

int[] arr = GetElements(num);
PrintArray(arr, "Ваш массив: ");

int[] GetElements(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение для элемента массива с индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}

void PrintArray(int[] array, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} [{str}]");

}





