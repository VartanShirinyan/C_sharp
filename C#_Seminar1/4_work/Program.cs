Console.WriteLine("Enter a three-digit integer number (Введите трехзначное число)");
int number = Convert.ToInt32(Console.ReadLine());
int last_digit = number%10;
Console.WriteLine($"Last digit of your number is(последняя цифра вашего номера) {last_digit}");
