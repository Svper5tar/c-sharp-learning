// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53




double Distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double distance = Math.Sqrt(Math.Pow((ax - bx), 2) +
                                Math.Pow((ay - by), 2) +
                                Math.Pow((az - bz), 2));
    return distance;
}

Console.WriteLine("Введите координату x(A)");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y(A)");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z(A)");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x(B)");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y(B)");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z(B)");
int bz = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(Distance(ax, ay, az, bx, by, bz), 2);
Console.WriteLine($"Pасстояние между точками в 3D пространстве: {distance}");
