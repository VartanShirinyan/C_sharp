﻿// Задача 20 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N. 5 -> 1, 4, 9, 16, 25. 2 -> 1,4 

try // Пытаемся выполнить ВЕСЬ программный код
    // Сюда засовываем всю основную программу, ну кроме функций разумеется.
{
    Console.WriteLine("Введите Число:");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i=1;i<=n;i++)
    {
        Console.Write($"Квадрат числа {i}: ");
        Console.WriteLine(kvadrat(i));
    }

}
catch // если же не получилось выполнить всю программу, то уходим в этот блок и информуруем пользователя
{
    Console.WriteLine("Ошибка: Надо было вводить именно целое число цифрами!");
}

// Функция возвращает число int ----------------------------------------------------

int kvadrat (int n)
{
    return n*n;
}
