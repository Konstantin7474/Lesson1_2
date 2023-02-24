/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double[] A = new double[2];
double[] B = new double[2];
double[] C = new double[2];

Console.Write($"Введите координаты точек через пробел\n");
string coords = Console.ReadLine()!;
string[] points = coords.Split(" ", ";");

if(points.Length !=6)
{
    Console.Write($"Введено неправильное количество точек ");
}
double.TryParse(points[0], out A[0]);
double.TryParse(points[1], out A[1]);
double.TryParse(points[2], out B[0]);
double.TryParse(points[3], out B[1]);
double.TryParse(points[4], out C[0]);
double.TryParse(points[5], out C[1]);

double ABC = Math.Round(Math.Sqrt(Math.Pow((A[0] - A[1]), 2) + Math.Pow((B[0] - B[1]), 2) + Math.Pow((C[0] - C[1]), 2) ));

Console.Write($"Расстояние между точками A({A[0]}; {A[1]}) и B({B[0]}; {B[1]}) и C({C[0]}; {C[1]}) = {ABC}");

