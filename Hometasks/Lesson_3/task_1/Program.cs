// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

bool IsValid(int num)
{
    if (num < 0)
    {
        num = num * -1;
    }
    if (num > 999 & num < 100000)
    {
        return true;
    }
    Console.WriteLine("Некорректное число.");
    return false;
}


bool IsPalindrome(int num)
{
    if ((num / 10000) == (num % 10))
    {
        if (((num % 10000) / 1000) == ((num % 100) / 10))
        {
            Console.WriteLine("Это палиндром.");
            return true;
        }
    }
    Console.WriteLine("Это не палиндром.");
    return false;
}


Console.WriteLine("Enter: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (IsValid(userNumber))
{
    IsPalindrome(userNumber);
}
