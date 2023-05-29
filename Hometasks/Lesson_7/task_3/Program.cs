// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3



int rows = 5;
int columns = 5;
int min = 1;
int max = 9;

int[,] matrix = CreateArray(rows, columns, min, max);
PrintArray2xInt(matrix);

Console.WriteLine();

double[] average = Average(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray1xDouble(average);


int[,] CreateArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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

void PrintArray2xInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5} ");
        }
        Console.WriteLine("   ]");
    }
}

void PrintArray1xDouble(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i],5} ");
    }
    Console.WriteLine("  ]");
}


double[] Average(int[,] matrix)
{
    double[] arrayAverage = new double[matrix.GetLength(0)];
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        
        arrayAverage[k] = (double) sum / matrix.GetLength(0);
        k++;
    }
    return arrayAverage;
}
