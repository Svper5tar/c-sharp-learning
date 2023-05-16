// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите минимальное значение для каждого элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение для каждого элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(min, max, size);
PrintArray(array);

int[] CreateArray (int min, int max, int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}