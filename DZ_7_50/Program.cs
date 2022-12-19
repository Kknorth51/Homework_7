﻿// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите резмер массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите искомое число");
// int s = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// int count = 0;

// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArray(array);

// for (int e = 0; e < array.GetLength(0); e++)
// {
//     for (int r = 0; r < array.GetLength(1); r++)
//     {
//         if (array[e, r] == s)
//         {
//             Console.WriteLine($"Искомое число находится в координате {e} и {r}");
//             count++;
//         }
//     }
//     Console.WriteLine();
// }
// if (count <= 0) Console.WriteLine($"Искомого числа нет!");

Console.WriteLine("Введите номер строки и столбца искомого элемента:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
SearchEl(m,n);

int [,] FillArray () 
{    
    int[,] array = new int[4,4];                                      
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            array[i,j] = Convert.ToInt32(new Random().Next(1, 10));   
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

void SearchEl(int m, int n) {
    int[,] array = FillArray();
    int val = 0;
    if(m <= array.GetLength(0) && n <= array.GetLength(1)) {      
     for(int i = 0; i < array.GetLength(0); i++) {
            for(int j = 0; j < array.GetLength(1); j++) {
            if(i == (m - 1) && j == (n - 1))
            val = array[--m,--n];                                 
        }          
       }
       Console.WriteLine($" Искомый элемент равен {val}");
    }
    else 
    Console.WriteLine($"{m}{n} - такого элемента в массиве нет");
}