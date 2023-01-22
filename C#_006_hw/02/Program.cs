Console.WriteLine("Введите значение первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введена первая прямая: b1 {b1}, k1 {k1}.");

Console.WriteLine("Введите значение второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введена вторая прямая: b2 {b2}, k2 {k2}.");

Console.WriteLine($"Точка пересечения двух прямых: [{String.Join(", ", getPoint(b1, k1, b2, k2))}]");

double[] getPoint(double b1, double k1, double b2, double k2) {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[] {y, x};
}