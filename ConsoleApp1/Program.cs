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