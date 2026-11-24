// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
int[] C = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int s = 0;
float g = 1;
int k = 0;

for (int i = 0; i < C.Length; i++)
{
    
   
    if (C[i] % 2 == 0)
    {
        g *= C[i];
        k += 1;
    }
    else
    {
        s += C[i];
    }
    
}

Console.WriteLine($"Среднее геом.: {g / k}");
Console.WriteLine($"Среднее арифм: {s / (C.Length-k)}"); 