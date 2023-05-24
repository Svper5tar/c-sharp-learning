// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько элементов будет в массиве?");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine($"Чисел в массиве больше 0: {NumberGreaterZero(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    int i = 0;
    while (i < size)
    {
        Console.Write($"Введите число номер {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        i++;
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < (array.Length); i++)
    {
        if (i < (array.Length - 1)) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");    
    }
}


int NumberGreaterZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    return result;
}