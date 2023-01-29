printArray(getSpiralArray());

int[,] getSpiralArray()
{
    int[,] array = new int[4, 4];
    int countRow = 0;
    int countColumn = 0;
    int number = new Random().Next(1, 10);
    while (!(array.GetLength(0) - countRow == 0))
    {
        for (int i = countColumn; i < array.GetLength(1) - countColumn; i++)
        {
            array[countRow, i] = number;
            number = new Random().Next(number + 1, number + 11);
        }
        for (int j = countRow + 1; j < array.GetLength(0) - countColumn; j++)
        {
            array[j, array.GetLength(1) - countColumn - 1] = number;
            number = new Random().Next(number + 1, number + 11);
        }
        for (int x = array.GetLength(1) - countColumn - 1; x > countRow; x--)
        {
            array[array.GetLength(0) - countRow - 1, x] = number;
            number = new Random().Next(number + 1, number + 11);
        }
        for (int y = array.GetLength(0) - countRow - 1; y > countRow; y--)
        {
            array[y, countColumn] = number;
            number = new Random().Next(number + 1, number + 11);
        }
        countRow++;
        countColumn++;
    }
    return array;
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