// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArray(double min, double max, int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}


double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}


double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double Difference(double min, double max)
{
    double difference = Math.Round(max - min, 1);
    return difference;
}


double[] array = CreateArray(0, 100, 10);
PrintArray(array);
Console.WriteLine($"Минимальный элемент массива: {MinElement(array)}");
Console.WriteLine($"Максимальный элемент массива: {MaxElement(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Difference(MinElement(array), MaxElement(array))}");