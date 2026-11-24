// See https://aka.ms/new-console-template for more information
using System;

//Вариант 3
//Вычислить среднее арифметическое элементов массива Т[15], удовлетворяющих условию 5 ≤ T[i] ≤ 15.



int[] T = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
int s = 0;
for (int i = 0; i < T.Length; i++)
{
        s += T[i];
}
Console.WriteLine($"Среднее арифм.: {s/ T.Length}");