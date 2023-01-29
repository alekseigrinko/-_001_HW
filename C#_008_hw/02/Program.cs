getMinRow(getArray(new int[new Random().Next(3, 11), new Random().Next(3, 11)]));

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
    Console.WriteLine("");
    return array;
}

void getMinRow(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        int sum = 0;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            sum += array[row, column];
        }
        if (row == 0) {
            minSum = sum;
        }
        if (sum < minSum) {
            minSum = sum;
            minRow = row;
        }
    }
    Console.WriteLine($"Строка №{minRow} содержит наименьшую сумму элементов!");
    Console.WriteLine("");
}