// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine(value: "Please, input the first integer number (Введите первое число)!");
// int num1 = Convert.ToInt32(value: Console.ReadLine());
// Console.WriteLine(value: "Please, input the second integer number different from the first!");
// int num2 = Convert.ToInt32(value: Console.ReadLine());

Console.WriteLine("Enter the Two Numbers (Введите два числа): ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 == num2 * num2)
{
    Console.WriteLine(value: "Первое число является квадратом второго!");
}
else if (num2 == num1 * num1)
{
    Console.WriteLine(value: "Второе число является квадратом Первого!");
}
else
{
    Console.WriteLine(value: "Квадраты чисел отсутствуют!");
}