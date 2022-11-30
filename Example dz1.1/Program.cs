//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.WriteLine("Hello, World!");

int NumberA = int.Parse(Console.ReadLine());
int NumberB = int.Parse(Console.ReadLine());

if (NumberB == NumberA)
{ Console.WriteLine("Введенные числа равны");}

else 
 if (NumberA > NumberB)
{ Console.WriteLine($"Большее число - {NumberA}");
Console.WriteLine($"Меньшее число - {NumberB}");}
else
{
Console.WriteLine($"Большее число - {NumberB}"); 
Console.WriteLine($"Меньшее число - {NumberA}");
}