int[,] firtsArray = getArray(new int[2, 2]);
int[,] secondArray = getArray(new int[2, 2]);
Console.WriteLine("Сгенерированы две матрицы случайных чисел: ");
printMatrix(firtsArray, secondArray);
Console.WriteLine("Итоговая матрица: ");
printArray(getResultMatrix(firtsArray, secondArray));

int[,] getArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 10);
        }
    }
    return array;
}

void printMatrix(int[,] firstArray, int[,] secondArray)
{
    for (int row = 0; row < firstArray.GetLength(0); row++)
    {
        for (int column = 0; column < firstArray.GetLength(1); column++)
        {
            Console.Write($"{firstArray[row, column]} ");
        }
        Console.Write($"| ");
        for (int c = 0; c < secondArray.GetLength(1); c++)
        {
            Console.Write($"{secondArray[row, c]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] getResultMatrix(int[,] fistArray, int[,] secondArray)
{
    int[,] result = new int[2, 2];

    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            int count = 0;
            for (int x = 0; x < firtsArray.GetLength(1); x++)
            {
                count += (firtsArray[i, x] * secondArray[x, j]);
            }
            result[i, j] = count;
        }
    }
    return result;
}

void printArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}