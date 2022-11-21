// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrixSumIndex(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
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

void PrintArrayResult(double[] array) 
{
        for (int i = 0; i < array.Length; i ++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}; ");
        }
        
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}. ");
        }
    }
}

void FindAverageColumn(double[,] array)
{

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] result = new double[columns]; 
    double count = 0;
    double sum = 0;
    double ave = 0;

    for (int j = 0; j < columns; j ++)
    {
        
        for (int i = 0; i < rows; i ++)
        {
            count++;
            sum = sum + array[i,j];
        }
        ave = sum/count;
        result[j] = Math.Round(ave, 2); 
        
        ave = 0; 
        count = 0;
        sum = 0;
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    PrintArrayResult(result);
}

double[,] array2D = CreateMatrixSumIndex(3, 4, 1, 9);
PrintMatrix(array2D);
FindAverageColumn(array2D);