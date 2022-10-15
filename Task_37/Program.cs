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

int[] Multiplication (int[] array)
{
    int lengthNewArray = default;
    if (array.Length % 2 == 0) lengthNewArray = array.Length / 2;
    else lengthNewArray = (array.Length / 2) + 1;
    int[] newArray = new int[lengthNewArray];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 == 1) newArray[newArray.Length -1] = array [array.Length / 2];
    return newArray;
}


int[] arr = CreateArrayRndInt(7, 0, 5);
PrintArray(arr);
int[] multiplication = Multiplication(arr);
PrintArray(multiplication);