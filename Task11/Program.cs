/*
11. Напишите программу, которая 
 1. выводит случайное трёхзначное число 
 2. удаляет вторую цифру этого числа.
 3. выводит результат 
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random(). Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {number}");
int result = GetNumber(number);
Console.WriteLine($"Результат удаления второй цифры этого числа: {result}");

int GetNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int finishNumber = firstDigit * 10 + secondDigit;
    return finishNumber;
}
