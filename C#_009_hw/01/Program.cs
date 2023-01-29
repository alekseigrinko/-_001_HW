Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все натуральные числа в промежутке от N до 1: ");
getNumber(number);
void getNumber(int number) {

    if (number == 1) {
        Console.Write("1");
    } else {
        Console.Write($"{number}, ");
        getNumber(number - 1);
    }
}