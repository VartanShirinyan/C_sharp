Console.WriteLine("Enter a positive integer(введите положительное целое число)");
int n = Convert.ToInt32(Console.ReadLine());
int k = -n;
while (k<n+1)
{
    Console.Write($"{k} ");
    k++;
}
Console.WriteLine();