//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int NumberC = int.Parse(Console.ReadLine());

if (NumberB == NumberA && NumberA == NumberC)
{   Console.WriteLine("Введенные числа равны"); }

if (NumberB < NumberA && NumberA > NumberC)
{   Console.WriteLine($"максимальное число - {NumberA}"); }
else
if (NumberA < NumberB && NumberB > NumberC)
{   Console.WriteLine($"максимальное число - {NumberB}"); }
else
if (NumberA < NumberC && NumberC > NumberA)
{
    Console.WriteLine($"Максимальное число - {NumberC}");
}
