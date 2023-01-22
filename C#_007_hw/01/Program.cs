getArray(new double[3, 4]);

void getArray(double[,] array)
{
    Console.WriteLine($"Сгенерирован двумерный массив случайных вещественных чисел: ");
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = new Random().NextDouble() * 40 - 20;
            Console.Write(string.Format("{0:F2} ", array[row, column]));
        }
        Console.WriteLine();
    }
}
