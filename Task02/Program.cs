// Задача 2: Напишите программу, которая 
// 1. на вход принимает два числа  
// 2. выдаёт, какое число большее, а какое меньшее
// 3. выводит результат
// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число 1:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число 2:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max={number1}");
}
else if (number1 < number2)
{
    Console.WriteLine($"max={number2}");
}