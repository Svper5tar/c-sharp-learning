// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 99 && userNumber < 1000 || userNumber < -99 && userNumber > -1000)
{
    Console.WriteLine(Math.Abs(userNumber / 10 % 10));
}
else
{
    Console.WriteLine("Вы ввели неверное число.");
}
