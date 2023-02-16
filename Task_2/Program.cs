/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/


int number1; 
int number2;

Console.Write($"Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out number1);
Console.Write($"Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out number2);
int max;
if (number1 > number2)
{
    Console.Write(max = number1);
}
if (number1 < number2)
{
    Console.Write(max = number2);
}
if (number1 == number2)
{
    Console.Write(number1 = number2);
}