/*
Задача 8: Напишите программу, которая 
 1. на вход принимает число (N)
 2. на выходе показывает все чётные числа от 1 до N.
 3. выводит результат
Например:
 5 -> 2, 4
 8 -> 2, 4, 6, 8
*/

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int count = 1;
while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    count++;
    }
    else
    {
        count++;
    }
}
}
else
{
    Console.WriteLine("Введено не натуральное число!");
}