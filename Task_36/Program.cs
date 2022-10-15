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


int SumEvenPosition(int[] array)
{
    int sum = default;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum = array[i] + sum;
    }
    return sum;
}

Console.WriteLine("Пожалуйста, введите длинну массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможное число массива");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможное число массива");
int maximal = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(lengthArr, minimal, maximal);
PrintArray(arr);
System.Console.WriteLine();
int sumEvenPosition = SumEvenPosition(arr);
System.Console.WriteLine($"Сумма чисел стоящих на не четных позициях -> {sumEvenPosition}");