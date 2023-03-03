/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = new int[size];


RandomNumbers(array);
PrintArray(array);

int res = 0;
for (int b = 0; b < array.Length; b++)
{
    if (b % 2 !=0)
    {
        res += array[b];
    }
    
}


Console.WriteLine($"Сумма элементов нечетных позиций = {res}");


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
