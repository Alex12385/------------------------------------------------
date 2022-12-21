// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите значение для элемента массива с индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());

}

int sum = GetPositiveElements(array);


PrintArray(sum, "Ваш массив: ");

int GetPositiveElements(int[] N)
{
    int posNum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > 0)
        { posNum++; }
    }

    return posNum;
}

void PrintArray(int N, string message)
{
    string str = string.Join(", ", array);
    Console.WriteLine($"{message} [{str}]");
    Console.Write($"Количество положительных элементов = {N}");
}