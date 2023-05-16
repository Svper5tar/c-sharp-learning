// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число, которое нужно возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень, в которую нужно возвести число {a}: ");
int b = Convert.ToInt32(Console.ReadLine());

if (IsValid(b)) Console.WriteLine($"Результат: {Exponentation(a, b)}");
else Console.WriteLine("Отрицательное значение степени не допускается.");


int Exponentation(int number, int powerOf)
{
    int index = 1;
    int result = number;
    if (powerOf == 0)
    {
        result = 1;
    }
    if (powerOf > 0)
    {
        while (index < powerOf)
        {
            result = result * number;
            index++;
        }
    }
    return result;
}


bool IsValid(int powerOf)
{
    if (powerOf < 0)
    {
        return false;
    }
    return true;
}