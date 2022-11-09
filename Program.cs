int getArraySize()
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

string[] keyboardInputStrArray(int size)
{
    string[] userArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Ввведите элемент массива: ");
        userArray[i] = Console.ReadLine();
    }
    return userArray;
}

void printArray(string[] userArray)
{
    Console.Write("[");
    for(int i = 0; i < userArray.Length-1; i++)
    {
        Console.Write($"{userArray[i]}, ");
    }
    Console.Write($"{userArray[userArray.Length-1]}");
    Console.WriteLine("]");
}

string[] getThreeSymbolLength(string[] userArray)
{
    int count = 0;
    string[] outputArray = new string[count];
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            count += 1;
            Array.Resize(ref outputArray, count);
            outputArray[count-1] = userArray[i];
        }
    }
    return outputArray;
}

int arraySize = getArraySize();
string[] manualArray = keyboardInputStrArray(arraySize);
Console.WriteLine("Исходный массив:");
printArray(manualArray);
string[] resultArrray = getThreeSymbolLength(manualArray);
Console.WriteLine("Результат:");
printArray(resultArrray);