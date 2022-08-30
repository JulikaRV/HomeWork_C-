// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("insert 1 numbers:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("insert 2 numbers:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("Ok");
}
else Console.WriteLine("Error");

