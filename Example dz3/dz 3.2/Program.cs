//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double FirstX = GetDistanceBetweenThreePoints(x1, y1, z1, x2, y2, z2);

double GetDistanceBetweenThreePoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int numX = (x1 - x2) * (x1 - x2);
    int numY = (y1 - y2) * (y1 - y2);
    int numZ = (z1 - z2) * (z1 - z2);
    int calculations = numX + numY + numZ;
    double result = Math.Sqrt((double)calculations);
    return result;
}
Console.WriteLine(FirstX);