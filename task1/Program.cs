﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int powNum(int a, int b)
{
    int result = Convert.ToInt32(Math.Pow(a,b));
    return result;
}

Console.WriteLine("Введите два числа A и B: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} равно {powNum(a,b)}");
