Console.WriteLine("Введите пятизначное число число: ");
int number = Convert.ToInt32(Console.ReadLine());
char[] array = number.ToString().ToCharArray();
if (number < 0) 
{
    Console.WriteLine($"Число {number} отрицательное!");
}

else
{

    if (array.Length != 5)
    {
        Console.WriteLine($"Число {number} не содержит 5 знаков!");
    }

    else 
    {
        if ((array[0] == array[4]) && (array[1] == array[3]))
        {
           Console.WriteLine($"Число {number} полиндром!");
        }

        else 
        {
           Console.WriteLine($"Число {number} не является полиндромом!");
        }
    }
}