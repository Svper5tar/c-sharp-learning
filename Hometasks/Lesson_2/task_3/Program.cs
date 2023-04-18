// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");
int userDay = Convert.ToInt32(Console.ReadLine());

if (ValidateDay(userDay))
{
    if (IsWeekend(userDay))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний день");
    }
}

bool ValidateDay(int day)
{
    if (day > 0 && day <=7)
    {
        return true;
    }
    Console.WriteLine("Ваше число не может являться днём недели");
    return false;
}

bool IsWeekend (int day)
{
    if (day > 5)
    {
        return true;
    }
    return false;
}

