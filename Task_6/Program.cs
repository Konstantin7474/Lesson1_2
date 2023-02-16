/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int number;

Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number % 2 == 0)
{
    Console.Write($"Кратно");
}
else
    Console.Write($"Не кратно");