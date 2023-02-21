/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.*/


int N;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

string str_N = N.ToString();


if (str_N.Length > 2)
    Console.Write($"{N} -> {str_N[2]}");

else
    Console.Write($"Нет 3 цифры");