﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, -10, 10);

PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double [m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
    return result;
}

void PrintArray (double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (j < inArray.GetLength(1) - 1) Console.Write($"{inArray[i, j]}, ");
            else Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}