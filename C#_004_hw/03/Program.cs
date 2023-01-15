Console.WriteLine("Введите знаечние длины генирируемого массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"[{String.Join(", ", getArray(size))}]");

int[] getArray(int size) {
    if (size <= 0) {
        Console.WriteLine("Введено некорректное знаечние размера массива, оно должно быть больше 0!");
        return new int[0];
    } else {
        int[] result = new int[size];
        for (int i = 0; i < result.Length; i++) {
            result[i] = new Random().Next(101);
        }
        return result;
    }
}

