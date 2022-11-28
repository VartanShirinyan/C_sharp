Console.WriteLine(value: "Please, input the first integer number!");
int n1 = Convert.ToInt32(value: Console.ReadLine());
Console.WriteLine(value: "Please, input the second integer number different from the first!");
int n2 = Convert.ToInt32(value: Console.ReadLine());

if (n1 == n2 * n2)
{
    Console.WriteLine(value: "Первое число является квадратом второго!");
}
else if (n2 == n1 * n1)
{
    Console.WriteLine(value: "Второе число является квадратом Первого!");
}
else
{
    Console.WriteLine(value: "Квадраты чисел отсутствуют!");
}