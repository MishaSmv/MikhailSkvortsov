﻿// Задача 4: Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. выдаёт максимальное из этих чисел.
// 3. выводит результутат
// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int count = 0;
if (number2 > max)
{
    max = number2;
    count++;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"max= {max}");
