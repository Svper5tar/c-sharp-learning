﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0) {
    Console.WriteLine("Число " + x + " является четным (остаток от деления " + x + " на 2 = " + x % 2 + ")");
}
else {
    Console.WriteLine("Число " + x + " является нечетным (остаток от деления " + x + " на 2 = " + x % 2 + ")");
}