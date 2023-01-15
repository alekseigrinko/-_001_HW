Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits(int numberForSum) {
    if (numberForSum < 0) {
        numberForSum *= -1;
    }
    return sumArray(numberForSum.ToString().ToCharArray());
}

int sumArray(char[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        result += (int)Char.GetNumericValue(array[i]);
    }
    return result;
}

Console.WriteLine($"Сумма всех цифр числа {number} равна: {sumOfDigits(number)}. ");