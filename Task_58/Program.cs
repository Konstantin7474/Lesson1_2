/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[m, n];
int [,] arraytwo = new int[m, n];
int [,] arrayresult = new int[m, n];




for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1 ,10);
    }
}


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arraytwo.GetLength(0); i++)
{
    for (int j = 0; j < arraytwo.GetLength(1); j++)
    {
        arraytwo[i, j] = new Random().Next(1 ,10);
    }
}


for (int i = 0; i < arraytwo.GetLength(0); i++)
{
    for (int j = 0; j < arraytwo.GetLength(1); j++)
    {
        Console.Write($"{arraytwo[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();


if (array.GetLength(0) != arraytwo.GetLength(1))
{
    Console.WriteLine(" Невозможно перемножить ");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < arraytwo.GetLength(1); j++)
    {
        arrayresult[i, j] = 0;
        for (int p = 0; p < array.GetLength(1); p++)
        {
           arrayresult[i, j] += array[i, p] * arraytwo[p, j]; 
        }
    }
}

for (int i = 0; i < arrayresult.GetLength(0); i++)
{
    for (int j = 0; j < arrayresult.GetLength(1); j++)
    {
        Console.Write($"{arrayresult[i, j]} ");
    }
    Console.WriteLine();
}