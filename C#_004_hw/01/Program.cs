Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0) {
    numberB *= -1;
    Console.WriteLine($"Число B является отрицательным, будет взято его модульное значение равное {numberB}.");
}

int exponentiate(int number, int degree) {
    int result = Convert.ToInt32(Math.Pow(number , degree));
    return result;
}

Console.WriteLine($"Число A в степени числа B будет равно: {exponentiate(numberA, numberB)}. ");