Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите тертье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB) 
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}

Console.WriteLine($"Саммое большое число {max}");