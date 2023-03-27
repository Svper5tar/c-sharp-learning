// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int number = 2;
if (x > 1) {
    while (x >= number) {

        Console.Write(number + " ");
        number = number +2;
    }
}