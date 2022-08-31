// Напишите программу, которая на вход принмает 3 трехзначных числа 
// и находит среднее арифметическое, далее проверяет больше ли последняя 
// цифра среднего арифметического, чем первая цифра минимума вводимых чисел.

// 111, 222, 333 - да
// 532, 164, 114 - нет
// 551, 235, 631 - цифры равны

Console.Clear();
Console.WriteLine("Введите первое число");
System.Console.Write("1 число: ");
int digit_1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("2 число: ");
int digit_2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("3 число: ");
int digit_3 = Convert.ToInt32(Console.ReadLine());

int avg = (digit_1 + digit_2 + digit_3) / 3;

System.Console.WriteLine($"среднее арифметическое = {avg}");

int min = digit_2;

if (min > digit_1)
{
    min = digit_1;
}
if (min > digit_3)
{
    min = digit_3;
}

Console.WriteLine("Min number is :  " + min);

if (avg % 10 > min % 100)
{
    System.Console.WriteLine("да");
}
else if (avg % 10 < min / 100)
{
    Console.WriteLine("нет");
}
else Console.WriteLine("цифры равны");
