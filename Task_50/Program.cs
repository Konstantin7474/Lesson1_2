/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[6,8];



if (m < array.GetLength(0) && n < array.GetLength(1)) Console.WriteLine(array[m, n]);
else Console.WriteLine($"{m} строка {n} столбец -> такого числа в массиве нет");


for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} "); 
    }
    Console.WriteLine();
}