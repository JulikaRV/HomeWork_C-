Console.Clear();
Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());

string? string1 = Console.ReadLine();
int number = 0;
if (string1 != null)
{
    number = int.Parse(string1);
}
else
{
    System.Console.WriteLine("Введите число");
}


//Решение математическим путем
int sqr = number * number;
System.Console.WriteLine($"Квадрат числа {number} равен {sqr}");

//Решение с использованием библиотеки

int sqr2 = Convert.ToInt32(Math.Pow(number, 2));
System.Console.WriteLine($"Квадрат числа {number} равен {sqr2}");
