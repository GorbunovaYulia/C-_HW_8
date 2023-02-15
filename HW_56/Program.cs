/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/
int[,] generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }

    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor($"{i + 1}" + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}

void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor($"{i + 1}" + "\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------------------------------------");
}

int getDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

int[] findRowSum(int[,] array, int rowLength)
{
    int[] result = new int[rowLength];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        result[k] = rowSum;
        k++;
    }
    return result;
}
int findMinSum(int[] array)
{
    int minSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minSum])
        {
            minSum = i;
        }
    }
    return minSum;
}

void printRowSum(int[] RowSum)
{
    for (int i = 0; i < RowSum.Length; i++)
    {
        Console.Write(RowSum[i] + "\t");
        Console.WriteLine();
    }
}

int rows = getDataFromUser("Введите количество строк");
int cols = getDataFromUser("Введите количество столбцов");
int[,] array = generate2DArray(rows, cols, 0, 10);
printArray(array);
int[] result = findRowSum(array, rows);
printRowSum(result);
int minSum = findMinSum(result);
printInColor($"Наименьшая сумма элементов в {minSum + 1} строке", ConsoleColor.Red);
