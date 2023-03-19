/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());


AkkermanFun(number1, number2);

void AkkermanFun(int number1, int number2)
{
    Console.WriteLine(Akker(number1, number2));
}

int Akker(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if (number2 == 0 && number1 > 0)
    {
        return Akker(number1 - 1, 1);
    }
    else
    {
        return (Akker(number1 - 1, Akker(number1, number2 - 1)));
    }
}