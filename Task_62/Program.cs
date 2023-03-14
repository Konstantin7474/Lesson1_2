/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int count = 4;
int [,] array = new int[count, count];
int m = 0;
int n = 0;
int temp = 1;
int t = 4;

for (int p = 0; p < t * t; p++)
{
    int f = 0;
    do { array[m, n++] = temp++; } while (++f < t - 1);
    for (f = 0; f < t - 1; f++) array[m++, n] = temp++;
    for (f = 0; f < t - 1; f++) array[m, n--] = temp++;
    for (f = 0; f < t - 1; f++) array[m--, n] = temp++;
    ++m;
    ++n;
    t = t < 2 ? 0 : t - 2;
}



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(array[i, j] < 10)
        {
            Console.Write("0" + array[i, j]);
            Console.Write(" ");
        }
        else Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}