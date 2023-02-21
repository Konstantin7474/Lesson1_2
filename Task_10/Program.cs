/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.*/


int N;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

string str_N = N.ToString();

if (str_N.Length > 3)
        Console.Write($"В заданном числе больше цифр ");

if (str_N.Length > 2)
    Console.Write($"{N} -> {str_N[1]}");

else
    Console.Write($"Нет 2 цифры");
