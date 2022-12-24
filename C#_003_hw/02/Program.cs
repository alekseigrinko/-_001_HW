Console.WriteLine("Введите кооридинаты точки А: ");
int[] A = new int[3];

A[0] = Convert.ToInt32(Console.ReadLine());
A[1] = Convert.ToInt32(Console.ReadLine());
A[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введены координаты точки А: {A[0]}, {A[1]}, {A[2]}.");

Console.WriteLine("Введите кооридинаты точки B: ");
int[] B = new int[3];

B[0] = Convert.ToInt32(Console.ReadLine());
B[1] = Convert.ToInt32(Console.ReadLine());
B[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введены координаты точки B: {B[0]}, {B[1]}, {B[2]}.");
double count = 0;
for (int i = 0; i < A.Length; i++)
{
    count += (Math.Pow(B[i] - A[i], 2));
}
double s = Math.Pow(count, (double)1 / 2);
Console.WriteLine($"Расстояние между введенными координатами равно: {s}.");