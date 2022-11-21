﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 |    7 | -2 | -0,2
//   1 | -3,3 |  8 | -9,9
//   8 |  7,8 |-7,1|    9

double[,] CreateMatrixSumIndex(int rows, int columns)
{
    double[,] matrix = new double[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 101)) / 10;
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

Console.Write("Введите количество строк массива: m=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк массива: n=");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array2D = CreateMatrixSumIndex(m, n);
PrintMatrix(array2D);