Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {getSumNumber(numberM, numberN)}.");
int getSumNumber(int M, int N)
{
    if (M == N) {
        return M;
    } 
    return M + getSumNumber(M+1, N);
}