Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int lengthArray)
{
    string[] arr = new string[lengthArray];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1} элемента");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountLengthNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] arr, int count)
{
    string[] newArr = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}



if (length < 0) Console.WriteLine("Вы ввели отрицательное число. Введите положительное целое число!.");
else
{
    string[] array = CreateArray(length);
    PrintArray(array);
    Console.WriteLine();

    int newLength = CountLengthNewArray(array);
    string[] newArray = CreateNewArray(array, newLength);
    PrintArray(newArray);
}
