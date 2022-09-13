// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int[] CreateArray(int num)

{
    Random rand = new Random();
    int[] array = new int[num];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(0, 20);
    }
    return array;

}

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}


int[] arr = CreateArray(num);
PrintArray(arr);
