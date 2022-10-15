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

int[] GetSumPositiveNegativeElements(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

int[] arr = CreateArrayRndInt(12, -9, 10);
PrintArray(arr);
System.Console.WriteLine();
int[] metamorfoza = GetSumPositiveNegativeElements(arr);
PrintArray(metamorfoza);