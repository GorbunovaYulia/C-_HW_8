/*
Задача 57. Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько рз встречается элемент входных данных.
Частотный массив
1, 9, 9, 8, 2, 8, 0, 9
0 встречается 1 раз
9 встречаетяс 3 раза
и тд.
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

int[] getFrequencyDictionary(int[,] array, int maxNumber)
{
    int[] result = new int[maxNumber];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[array[i, j]] += 1;
        }
    }
    return result;
}

void printFrequencyDictionary(int[] FrequencyDictionary)
{
    for (int i = 0; i < FrequencyDictionary.Length; i++)
    {
        if (FrequencyDictionary[i] > 0)
        {Console.WriteLine($"{i} встречается {FrequencyDictionary[i]} раза");}
    }
}

int[,] array = generate2DArray(5, 5, 0, 20);
printArray(array);
int[] FrequencyDictionary = getFrequencyDictionary(array, 21);
printFrequencyDictionary(FrequencyDictionary);