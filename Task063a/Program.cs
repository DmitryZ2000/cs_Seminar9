﻿// Задача 63: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintNumbers(int start, int end)
{
    if (start > end) return;
    Console.Write($"{start} ");
    PrintNumbers(start + 1, end);
}

// Console.Write("Введите любое целое число ");
// int number = Convert.ToInt32(Console.ReadLine());
int number = 6;
PrintNumbers(1, 6);