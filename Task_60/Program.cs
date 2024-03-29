﻿/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/


int [,,] array = new int[2, 2, 2];
int count = 10;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int p = 0; p < array.GetLength(2); p++)
        {
            array[p, i, j] += count;
            count += 3;
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.WriteLine();
        for (int p = 0; p < array.GetLength(2); p++)
        {
            Console.Write($"{array[i, j, p]}({i},{j},{p}) ");
        }
    }
}
