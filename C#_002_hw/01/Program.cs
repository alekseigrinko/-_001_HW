Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
char[] array = number.ToString().ToCharArray();

if (array.Length != 3)
{
    Console.WriteLine($"Вы ввели не трёхзначное число. Ваше число содержит {array.Length} знак (-а)!");
}

if (array.Length == 3)
{
Console.WriteLine($"Второй знак введённого числа {array[1]}!");
}
