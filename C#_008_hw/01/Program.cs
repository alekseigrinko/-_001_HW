sortArray(getArray(new int[new Random().Next(3, 11), new Random().Next(3, 11)]));

int[,] getArray(int[,] array)
{
    Console.WriteLine($"Сгенерирован двумерный массив случайных чисел: ");
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().Next(1, 30);
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

void sortArray(int[,] array)
{
    Console.WriteLine($"Отсротирован введенный двумерный массив: ");
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int count;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            for (int j = column + 1; j < array.GetLength(1); j++)
            {
                if (array[row, column] < array[row, j])
                {
                    count = array[row, column];
                    array[row, column] = array[row, j];
                    array[row, j] = count;
                }
            }
        }
    }
    printArray(array);
    Console.WriteLine();
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