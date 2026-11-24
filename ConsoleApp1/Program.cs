// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
(int Min, int Max) MinMax(int[] numbers)
{
    int min = numbers.Min();
    int max = numbers.Max();
    return (min, max);
}

var (min, max) = MinMax(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine($"Min: {min}, Max: {max}");