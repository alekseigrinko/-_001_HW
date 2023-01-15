double[] array = getArray(new double[new Random().Next(20)]);

Console.WriteLine($"Сгенерирован массив случайных вещественных чисел: [{String.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {getResult(array)}.");

double[] getArray(double[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().NextDouble() * 200 - 100;
    }
    return array;
}

double getResult(double[] array) {
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        } 
        if (array[i] < min) {
            min = array[i];
        }
    }
    return max - min;
}