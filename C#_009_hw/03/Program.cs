Console.WriteLine("Введите неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана двух неотрицательных чисел m и n: {function(numberM, numberN)}.");
int function(int m, int n)
{
    if (m == 0) {
        return n + 1;
    } else if ((m != 0) && (n == 0)) {
        return function(m -1, 1);
    } else {
        return function(m - 1, function(m, n - 1));
    }
}