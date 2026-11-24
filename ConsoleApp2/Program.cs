// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

int[] T = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
float s = 0;
for (int i = 0; i < T.Length; i++)
{
        s += T[i];
}
Console.WriteLine($"Среднее арифм.: {s/ T.Length}");