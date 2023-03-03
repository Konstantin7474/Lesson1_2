/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

 

int N ;
int P = 0;
Console.WriteLine($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

string str_N = N.ToString();

if (str_N.Length > 5 || str_N.Length < 5)
    Console.Write($"Вы ввели не пятизначное число ");

while(N > 0)
{
    int NUM = N % 10;
    P = (P * 10) + NUM;
    N = N / 10;

}
if(P == N)
{
    Console.Write($"Полиндром ");
}
else
{
    Console.Write($"Не полиндром ");
}
    