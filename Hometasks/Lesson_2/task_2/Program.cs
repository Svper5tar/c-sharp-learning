// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (ValidateUserNumber(userNumber))
{
    Console.WriteLine(ThirdDigit(userNumber));
}

bool ValidateUserNumber(int number)
{
    if (number > 99)
    {
        return true;
    }
    Console.WriteLine("Число меньше 100");
    return false;   
}

int ThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
