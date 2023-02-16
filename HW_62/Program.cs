/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*int[] array = new int[n - m + 1];
        for (int i = 0; i < array.Length; i++) {
            array[i] = m++;
        }
*/

int[,] generate2DArray(int length)
{
    int[,] array = new int[4, 4];
    int n = 1;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            array[i, j] = n++;
        }

    }
    return array;
}

void printNewArray(int[,] array)
{
    int i = 0;
    int j = 0;
    for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    for (i = 1; i < array.GetLength(0); i++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    for (j = array.GetLength(1) - 1; j > -1; j--)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
        for (i = 1; i < array.GetLength(0); i++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
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
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}

void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int getDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}


int[,] array = generate2DArray(4);
printArray(array);
Console.WriteLine();
Console.WriteLine();
printNewArray(array);


