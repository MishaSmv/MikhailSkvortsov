// 7. Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. на выходе показывает последнюю цифру этого числа.
// 3. выводит результат
// Например: 
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное целое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    if (number < 1000)
    {
        int lastDigit = number % 10;
        Console.WriteLine($"{lastDigit}");
    }
    else
    {
        Console.WriteLine("Введено не соответствующее число!");
    }
}
else
{
    Console.WriteLine("Введено не соответствующее число!");
}
