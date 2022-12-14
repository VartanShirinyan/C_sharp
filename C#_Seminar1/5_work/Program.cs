// **Задача 7 HARD: - илет за 2 необязательных** Напишите программу, 
// которая принимает на вход целое число любой разрядности 
// и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4


Console.WriteLine("Enter an integer number (Введите целое число)");
int number = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;
if (number > 99)
{
    k = number;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
Console.WriteLine($"The third number from the left is {d}");
}
else
{
    Console.WriteLine($"The number has fewer then 3 digits, sorry.");
}