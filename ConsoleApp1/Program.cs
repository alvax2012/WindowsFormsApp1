// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
(int index, int Max) ArrMax(int[] numbers)
{
    
    int max = numbers.Max();
    int index = Array.IndexOf(numbers, max);
    return (index, max);
}

var (index, max) = ArrMax(new int[] { 1, 2, 3, 4, 5 });
Console.WriteLine($"index: {index}, Max: {max}");