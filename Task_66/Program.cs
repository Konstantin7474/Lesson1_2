/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumberSum(number1, number2);

void NaturalNumberSum(int number1, int number2)
{
    Console.WriteLine(Sum(number1 - 1, number2));
}

int Sum(int number1, int number2)
{
    int count = number1;
    if (number1 == number2)
        return 0;
    else
    {
        number1++;
        count = number1 + Sum(number1, number2);
        return count;
    }
}
