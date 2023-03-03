/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];


RandomNumbers(array);
PrintArray(array);

int maxFind = array[0];
int minFind = array[0];


for (int b = 0; b < array.Length; b++)
{
    if (array[b] > maxFind)
    {
        maxFind = array[b];
    }
    if (array[b] < minFind)
    {
        minFind = array[b];
    }
    
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxFind - minFind}");


void RandomNumbers(int[] array)
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max);
    }
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}