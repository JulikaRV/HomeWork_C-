//  Напишите программу, которая на вход принимает радиус круга
//   и находит его площадь округленную до целого числа, необходимо 
//   вывести максимальную цифру в полученном округлённом значении площади круга

// 10 -> 4
// 20 -> 7
// 30 -> 8

Console.Clear();

int getDigit(int k)
{
    int max = 0;
    while (k > 0)
    {
        if (max < k % 10) max = k % 10;
        k /= 10;
    }
    return max;
}

Console.WriteLine("Введите радиус круга");

System.Console.Write("R: ");
int r = Convert.ToInt32(Console.ReadLine());

double s = Math.Pow(r, 2) * Math.PI;
// int i = (int)Math.Round(s, 3, MidpointRounding.AwayFromZero);
int i = (int)Math.Round(s);
System.Console.WriteLine("Округленная площадь круга равна " + i);

int number = getDigit(i);
Console.WriteLine($"Максимальная цифра в полученном  значении равна {number}");





