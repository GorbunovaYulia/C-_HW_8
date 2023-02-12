/*
53. Задайте двумерный массив.
Поменять местами первую и последнюю строчку массива.
*/

int[,] generate2DArray(int colLength, int rowLength, int start, int finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
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
    Console.WriteLine("-----------------------------------------------------");
}

int[,] swapRows(int[,] array, int col1, int col2)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[col1, j];
        array[col1, j] = array[col2, j];
        array[col2, j] = temp;
    }
    return array;
}

int[,] array = generate2DArray(3, 7, -5, 10);
printArray(array);
int[,] swapedArray = swapRows(array, 0, array.GetLength(0) - 1);
printArray(swapedArray);
