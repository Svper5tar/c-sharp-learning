// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (y > max) {
    max = y;
}
if (z > max) {
    max = z;
}
Console.Write("Максимальное число: " + max);