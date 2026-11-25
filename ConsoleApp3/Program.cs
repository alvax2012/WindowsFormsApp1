// See https://aka.ms/new-console-template for more information
using System;


{
    //Вариант 4
    //Вычислить среднее геометрическое четных и сумму нечетных элементов массива С[10].

    Console.WriteLine("Hello, World!");
    int[] C = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int s = 0;
    int g = 1;
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
    Console.WriteLine($"Среднее арифм: {s / (C.Length - k)}");
}



{
    //Вариант 3
    //Вычислить среднее арифметическое элементов массива Т[15], удовлетворяющих условию 5 ≤ T[i] ≤ 15.

    int[] T = new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
    int s = 0;
    for (int i = 0; i < T.Length; i++)
    {
        s += T[i];
    }
    Console.WriteLine($"Среднее арифм.: {s / T.Length}");
}

{
    //Вариант 5
    //Найти количество элементов массива В[16], кратных 4 и не больше заданного числа a.

    int[] B = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //int s = 0;
    int k = 0;
    int a = 5;

    for (int i = 0; i < B.Length; i++)
    {


        if (B[i] % 4 == 0 & B[i] < a)
        {

            k += 1;
        }


    }

    Console.WriteLine($"кол.: {k}");
}