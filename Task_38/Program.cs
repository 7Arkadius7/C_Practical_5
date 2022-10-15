Console.Clear();

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next(min, max + 1)) / 10;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.Write("]");
}

double[] MaxMinNumbers(double[] array)
{
    double[] newArray = new double[2];
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    newArray[0] = min;
    newArray[1] = max;
    return newArray;
}

Console.WriteLine("Пожалуйста, введите длинну массива");
int lengthArr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможный элемент массива");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможный элемент массива");
int maximal = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndInt(lengthArr, minimal*10, maximal*10);
PrintArray(arr);
double [] newArray = MaxMinNumbers(arr);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным элементом массива {newArray[1]} и минимальным элементом массива {newArray[0]}  -> {newArray[1] - newArray[0]}");