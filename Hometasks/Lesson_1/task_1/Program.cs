// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x == y) {
    Console.WriteLine("Эти числа равны");
}
if (x < y) {
    Console.WriteLine("Большее число: " + y);
    Console.WriteLine("Меньшее число: " + x);
}
if (x > y) {
    Console.WriteLine("Большее число: " + x);
    Console.WriteLine("Меньшее число: " + y);
} 
