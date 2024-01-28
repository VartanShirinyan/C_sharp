// Напишите программу, которая на вход принимает число 
// и выдает его квадрат (число умноженное на само себя).
// 4->16
// 3->9
// 7->49

Console.WriteLine("Enter an integer (введите целое число)");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
//Console.WriteLine("Квадрат введенного числа равен "+square);
Console.WriteLine($"Квадрат введенного числа равен " + square); // $-форматированный вывод

if (num > 9)
{
    Console.WriteLine("Вы ввели число больше 9");
}
else
{
    Console.WriteLine("Вы ввели число меньше 10");
}
while (num <= 25) // выводит все числа от введенного до 25
{
    Console.Write($"{num} ");
    num++;
}
