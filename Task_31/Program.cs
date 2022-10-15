Console.Clear();

// Console.Clear();

// int[] arr = new int[12];


// void FillArray(int[] ar)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < ar.Length; i++)
//     {
//         ar[i] = rnd.Next(-9, 10);
//     }
// }

// FillArray(arr);

// void PrintArray(int[] ar)
// {
//     int count = ar.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{ar[position]}, ");
//         position++;
//     }
// }

// PrintArray(arr);
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
int sumPositive = default;
int sumNegative = default;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]<0) sumNegative += array[i];
    else sumPositive += array[i];
}
return new int[] {sumNegative, sumPositive};
}

int[] arr =  CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] getSumPositiveNegativeElements =GetSumPositiveNegativeElements(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма моложительных элементов = {getSumPositiveNegativeElements[0]}");
System.Console.WriteLine($"Сумма отрецательных элементов = {getSumPositiveNegativeElements[1]}");


