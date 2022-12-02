// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter the Two Numbers (Введите два числа):");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

int d = numA % numB;

if (numA % numB == 0)
{
    Console.WriteLine($"Число {numA} кратно {numB}");
}
else
{
    Console.WriteLine($"Число {numA} не кратно {numB}, деление от остатка {d}");
}