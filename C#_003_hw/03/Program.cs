Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) 
{
    Console.WriteLine($"Число {number} отрицательное!");
}

else 
{
    int[] array = new int[number];
    for (int i = 1; i <= number; i++)
    {
        array[i-1] = Convert.ToInt32(Math.Pow(i , 3));
    }

    Console.WriteLine($"Кубы чисел от 1 до {number}: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i != number - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(".");
}