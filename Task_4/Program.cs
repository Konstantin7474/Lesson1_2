/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int number1; 
int number2;
int number3;
int max;

Console.Write($"Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out number1);
Console.Write($"Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out number2);
Console.Write($"Введите 3 число: ");
int.TryParse(Console.ReadLine()!, out number3);

if ( number1 > number2 && number1 > number3)
{
     Console.Write(max = number1);
     Console.WriteLine($" Максимальное число ");   
}

if ( number2 > number1 && number2 > number3)
{
     Console.Write(max = number2);
     Console.WriteLine($" Максимальное число ");   
}

if ( number3 > number1 && number3 > number2)
{
     Console.Write(max = number3);
     Console.WriteLine($" Максимальное число ");   
}
