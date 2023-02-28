/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int numberA; 
int numberB;

Console.Write($"Введите A число: ");
int.TryParse(Console.ReadLine()!, out numberA);
Console.Write($"Введите B число: ");
int.TryParse(Console.ReadLine()!, out numberB);

Console.WriteLine("число A в степени B = " + Math.Pow(numberA, numberB));

/*if (numberB > times)
{
    result = numberA * numberA;
}
else
{
    Console.WriteLine("число A в степени B = " + result);
}*/