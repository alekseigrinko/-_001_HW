int[] array = getArray(new int[new Random().Next(20)]);

Console.WriteLine($"Сгенерирован массив случайных чисел до 100: [{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве: {sumOfOddElements(array)}.");

int[] getArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100);
    }
    return array;
}

int sumOfOddElements(int[] array) {
    int result = 0;
    for (int i = 1; i < array.Length; i += 2) {
        result += array[i];
    }
    return result;
}