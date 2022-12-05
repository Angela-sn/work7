// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int rows = Element("введите позицию элемента в строке: ");
int columns = Element("введите позицию элемента в столбце: ");
int[,] num = new int[4, 6];
GetArray(num);
PrintArray(num);
if (rows < num.GetLength(0) && columns < num.GetLength(1)) 
Console.WriteLine(num[rows, columns]);
else 
Console.WriteLine($"{rows}, {columns} -> такого элемента в массиве нет");

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Element(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

