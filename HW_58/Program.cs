/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int getDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.Yellow);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

int[,] findMultiplyArrays(int[,] array1, int[,] array2)
{
    int rowLength = array1.GetLength(0);
    int colLength = array2.GetLength(1);
    int[,] arrayMyltiply = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            arrayMyltiply[i, j] = array1[i, 0] * array2[0, j];
            for (int k = 1; k < array2.GetLength(0); k++)
            {
                arrayMyltiply[i, j] = arrayMyltiply[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
    return arrayMyltiply;
}

int start = getDataFromUser("Введите начальное значение диапазона чисел");
int finish = getDataFromUser("Введите конечное значение диапазона чисел");
int[,] array1 = generate2DArray(5, 4, start, finish);
int[,] array2 = generate2DArray(4, 3, start, finish);
printArray(array1);
printArray(array2);
int[,] MultiplyArrays = findMultiplyArrays(array1, array2);
printArray(MultiplyArrays);
