Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
char[] array = number.ToString().ToCharArray();

if (array.Length < 3)
{
    Console.WriteLine($"Число {number} не содержит 3-й знак!");
}

else
{
    Console.WriteLine($"Третий знак введённого числа {array[2]}!");
}