Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Первое число {numberA} больше второго числа {numberB}");
}

else if (numberA < numberB)
{
    Console.WriteLine($"Первое число {numberA} меньше второго числа {numberB}");
}

else 
{
    Console.WriteLine($"Первое число {numberA} равно второму числу {numberB}");
}