﻿// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int f = 1;
for (int i = 1; i <= N; i++) f = f * i;
Console.WriteLine(f);