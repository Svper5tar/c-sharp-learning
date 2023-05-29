// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int rows = 5;
int columns = 5;
int min = 0;
int max = 9;

double[,] matrix = CreateArray(rows, columns, min, max);
PrintArray(matrix);

Console.Write("Введите строку: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите столбец: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

ElementSearch(matrix, x, y);




double[,] CreateArray(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5} ");
        }
        Console.WriteLine("   ]");
    }
}


void ElementSearch(double[,] matrix, int x, int y)
{
    if (matrix.GetLength(0) >= x && matrix.GetLength(1) >= y) Console.WriteLine($"Элемент на позиции [{x}, {y}] : {matrix[x - 1, y - 1]}");
    else Console.WriteLine($"В позиции [{x}, {y}] нет элементов");
}