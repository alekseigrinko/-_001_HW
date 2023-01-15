int[] array = getArray(new int[new Random().Next(100)]);

Console.WriteLine($"Сгенерирован массив трехзначных чисел: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {sumOfEvenNumber(array)}.");

int[] getArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int sumOfEvenNumber(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i]%2 == 0) {
            result++;
        }
    }
    return result;
}