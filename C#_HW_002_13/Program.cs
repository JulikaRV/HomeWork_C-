// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(number > 99 ? number.ToString()[2] : "третьей цифры нет");


int getDigit(int k)
{
    while (k >= 1000) k = k / 10;
    int n = k % 10;
    return n;
}


Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
int newDigit = 0;

if (digit > 100)
{
    newDigit = getDigit(digit);
    Console.WriteLine(newDigit);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

