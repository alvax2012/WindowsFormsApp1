// See https://aka.ms/new-console-template for more information
using System;

//Вариант 1
//Создайте метод ArrMax(), который принимает одномерный массив и возвращает максимальный элемент и его индекс в массиве.

//(int index, int Max) ArrMax(int[] numbers)
//{

//    int max = numbers.Max();
//    int index = Array.IndexOf(numbers, max);
//    return (index, max);
//}

//var (index, max) = ArrMax(new int[] { 1, 2, 3, 4, 5 });
//Console.WriteLine($"index: {index}, Max: {max}");

int ArrMax1(int[] numbers)
{
    int index = 0;
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i])
        { 
            max = numbers[i];
            index = i;  
        
        }
        
    }
    Console.WriteLine($"index: {index}");
    Console.WriteLine($"Max: {max}");
    return index;
}
int[] A = new int[] { 1, 2, 3, 4, 5 };
int maxIndex = ArrMax1(A);
Console.WriteLine($"Max: {A[maxIndex]}");

Console.WriteLine();
//Вариант 2
//Вводятся три числа — длины трех сторон треугольника. Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.

int Perimeter(int a, int b, int c)
{
    return a + b + c;
}
Console.WriteLine($"Периметр: {Perimeter(1, 2, 3)}");
Console.WriteLine();

//Вариант 3
//Создайте метод GetPow(), который принимает два целочисленных аргумента — число и степень. Метод возвращает результат возведения числа в степень.
int GetPow(int a, int n)
{
    int res = 1;
    for (int i = 0; i < n; i++)
    {
       res *= a;

    }
    return res;
}
Console.WriteLine($"GetPow: {GetPow(2, 3)}");
Console.WriteLine();

//Вариант 4
//Создайте метод Distance() который вычисляет расстояние между двумя точками на плоскости. Координаты точек вводятся (переменные x1, y1 — для первой точки, и x2, y2 — для второй).

double Distance(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2));
}
Console.WriteLine($"Distance: {Distance(1, 2, 1, 2)}");
Console.WriteLine();

//Вариант 5
//Создайте метод MinMax() который принимает два целочисленных аргумента и меняет их значения таким образом, что первый становится максимальным, а второй — минимальным (меняет значения аргументов, если требуется). 

void MinMax(ref int a, ref int b)
{
    if (a < b)
    {
        (a, b) = (b, a);
    }
    
}
int a = 1;
int b = 2;
MinMax(ref a, ref b);
Console.WriteLine($"MinMax: {a} {b}");
Console.WriteLine();
