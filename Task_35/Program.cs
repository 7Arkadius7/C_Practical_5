Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.Write("]");
}

int CheckNumber(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] < max + 1)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите длинну массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число от какого минимального числа искать");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число до какого максимального числа искать");
int maximal = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(lengthArr, -30, 30);
PrintArray(arr);
System.Console.WriteLine();
int checkNumber = CheckNumber(arr, minimal, maximal);
System.Console.WriteLine($"Количество чисел в массиве от {minimal} до {maximal} -> {checkNumber}");