/*Задача 55. Задайте двумерный массив.
Заменить строки на столбцы. В случае, если это невозможно, должновыйти сообщение пользователю.
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

bool checkCanRotate(int rows, int cols)
{
    return rows == cols;
}

int[,] rotateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }

    }
    return array;
}

int rows = getDataFromUser("Введите количество строк");
int cols = getDataFromUser("Введите количество столбцов");
bool CanContinue = checkCanRotate(rows, cols);
if (CanContinue)
{
    int[,] array = generate2DArray(rows, cols, 0, 50);
    printArray(array);
    int[,] rotateArray = rotateMatrix(array);
    printArray(rotateArray);
}
else
{
    printInColor($"Для переворота квадратная матрица. Вы ввели [{rows}, {cols}]", ConsoleColor.Red);
}


