﻿/*Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int N;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

for (int i = 1; i * i * i <= N; i++);
    Console.Write($"{i * i * i}");