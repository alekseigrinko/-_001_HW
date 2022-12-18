Console.WriteLine("Введите число, порядкового номера дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) 
{
    Console.WriteLine($"Число {number} не соответствует ни одному из семи дней недели!");
}

if (number == 6) 
{
    Console.WriteLine($"{number}-й день недели выходной - суббота!");
}

else if (number == 7) 
{
    Console.WriteLine($"{number}-й день недели выходной - воскресенье!");
}

else 
{
    Console.WriteLine($"Вы ввели номер буднего дня недели. До субботы осталось {6 - number} дн.");
}