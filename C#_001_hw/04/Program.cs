Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

Console.WriteLine($"Все чётные число до числа {number} включительно: ");
while (count <= number) {
    if (count%2 == 0) 
        {
            Console.Write($" {count}");
        }
    count++;
}
Console.Write(".");

