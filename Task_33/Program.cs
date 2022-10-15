Console.Clear();

Console.WriteLine("Введите число для поиска его в массиве");
int number = Convert.ToInt32(Console.ReadLine());

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

bool CheckNumber(int[] array, int arg)
{
    bool checknum = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
        {
            checknum = true;
            break;
        }
    }
    return checknum;

}

int[] arr = CreateArrayRndInt(12, -9, 10);
PrintArray(arr);
System.Console.WriteLine();
bool checkNumber = CheckNumber(arr, number);
if (checkNumber) System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");