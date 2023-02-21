/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/


int N;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
 
 if (N > 7 || N < 1)
    Console.Write($"Вы ввели неверное число ");
if (N == 6 || N == 7)
    Console.Write("Да");
if (N == 5 || N == 4)
    Console.WriteLine("Нет");
if (N == 3 || N == 2)
    Console.WriteLine("Нет");
if (N == 1)
    Console.WriteLine("Нет");

    

