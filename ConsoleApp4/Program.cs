// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Вариант 5
//Найти количество элементов массива В[16], кратных 4 и не больше заданного числа a.


int[] B = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int s = 0;
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