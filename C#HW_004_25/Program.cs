// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

var rnd = new Random();

int num1 = rnd.Next(2, 10);
System.Console.WriteLine($" Число A => {num1}");
int num2 = rnd.Next(1, 10);
System.Console.WriteLine($" Число B => {num2}");


int Pow(int num, int n)
{
    int powNum = 1;
    for (int i = 0; i < n; i++)
    {
        powNum *= num;
    }
    return powNum;
}

int result = Pow(num1, num2);
System.Console.WriteLine($"Число A в натуральной степени B = {result}");
