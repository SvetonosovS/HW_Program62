// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int row = 4; 
int column = 4; 
int[,] array = FillArray(row, column);
PrintArray(array);

static int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    int i = 0;
    int j = 0;
    array[i, j] = 1;

    while (true)
    {
        while (j + 1 < column && array[i, j + 1] == 0)
        {
            array[i, j + 1] = array[i, j] + 1;
            j += 1;
        }
        while (i + 1 < row && array[i + 1, j] == 0)
        {
            array[i + 1, j] = array[i, j] + 1;
            i += 1;
        }
        while (j > 0 && array[i, j - 1] == 0)
        {
            array[i, j - 1] = array[i, j] + 1;
            j -= 1;
        }
        while (i > 0 && array[i - 1, j] == 0)
        {
            array[i - 1, j] = array[i, j] + 1;
            i -= 1;
        }
        if (array[i, j] == row * column)
            break;
    }
    return array;
}

static void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}