/*Задача 29: Напишите программу, которая задаёт массив из
 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


/*int [] array = FillArray(8);


int[] FillArray(int size, int min = 0, int max = 8)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}

Console.Write(array);*/



class ArrayDemo {
    static void Main() {
        int[] array = new int[8];
        int i;
        for(i = 0; i < 8; i = i+1)
            array[i] = i;
        for(i = 0; i < 8; i = i+1)
            Console.Write( array[i]);
    }
}