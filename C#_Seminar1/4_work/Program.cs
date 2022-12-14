// Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Enter a three-digit integer number (Введите трехзначное число)");
int number = Convert.ToInt32(Console.ReadLine());
int last_digit = number%10;
Console.WriteLine($"Last digit of your number is(последняя цифра вашего числа) {last_digit}");
