Console.Write($"Введите позиции элемента массива для его поиска, ");
Console.Write($"после этого будет сгенирован массив от 3 до 10 строк и столбцов!");
Console.WriteLine($"Введите значение строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение столба: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = getArray(new int[new Random().Next(3,11), new Random().Next(3,11)]);
checkElement(row, column, array);

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

void checkElement(int row, int column, int[,] array) {
    if ((row > (array.GetLength(0) - 1)) || (column > (array.GetLength(1) - 1))) {
        Console.WriteLine($"Такого элемента нет в массиве!");
    } else {
        Console.WriteLine($"Элемент массива [{row}, {column}]: {array[row, column]}");
    }
}
