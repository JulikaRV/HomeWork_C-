// Напишите программу, которая задаёт массив из 10 элементов, 
// которые необходимо заполнить случайными значениями в диапазоне 
// от -10 до 10 и найти максимальное значение среди них

// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9

// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6

// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

int[] CreateArray(int num)

{
    Random rand = new Random();
    int[] array = new int[num];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
    return array;
}

int FindMax(int[] array)
{
    int maxPosition = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxPosition)
        {
            maxPosition = array[i];
        }
    }
    return maxPosition;
}

void PrintArray(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int[] arr = CreateArray(10);
int max = FindMax(arr);
PrintArray(arr);
System.Console.WriteLine($" -> {max}");
