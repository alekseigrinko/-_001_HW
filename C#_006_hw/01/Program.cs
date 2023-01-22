Console.WriteLine("Введите числа через проблем или запятую: ");
String str = Console.ReadLine();
List<int> result = getNumbers(str);
Console.WriteLine($"Получился массив чисел: [{String.Join(", ", result)}]");
Console.WriteLine($"Положительных чисел в массиве получилось: {countPositiveNumbers(result)}");

List<int> getNumbers(String userString) // метод очистки введенной пользователем строки от лишних символов
{
    String[] strArray = userString.Split(' ', ',');
    List<int> numbers = new List<int>();
    for (int i = 0; i < strArray.Length; i++)
    {
        foreach (char c in strArray[i])
        {
            strArray[i] = strArray[i].Replace(" ", String.Empty);
        }
        if(!String.IsNullOrEmpty(strArray[i])) {
            numbers.Add(Convert.ToInt32(strArray[i]));
        }
    }
    return numbers;
}

int countPositiveNumbers(List<int> numbers) {
    int count = 0;
    foreach (int number in numbers) {
        if (number > 0) {
            count++;
        }
    }
    return count;
}