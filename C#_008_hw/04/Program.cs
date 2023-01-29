getArray(new int[2, 2, 2]);

void getArray(int[,,] array)
{
    Console.WriteLine($"Сгенерирован трёхмерный массив случайных чисел: ");
    for (int x = 0; x < array.GetLength(2); x++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j, x] = new Random().Next(10, 100);
                Console.Write($"{array[i, j, x]} ({i}, {j}, {x}) ");
            }
            Console.WriteLine();
        }
    }
}