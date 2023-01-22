int[,] array = getArray(new int[new Random().Next(3,11), new Random().Next(3,11)]);
countColumns(array);

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
    return array;
}

void countColumns(int[,] array) {
    double[] counts = new double[array.GetLength(1)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        int count = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            count += array[row, column];
        }
        counts[column] = Math.Round((Convert.ToDouble(count) / array.GetLength(0)), 2);
    }
    Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: [ {String.Join(" | ", counts)} ]");
}