﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string rec(int n)
{
    if (n == 0)
        return "";
    return $"{n} " + rec(n-1);
}


Console.Write("Введите элемент: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n));