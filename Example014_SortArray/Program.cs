// Упорядочить массив

int[] arr = { 13, 24, 13, 47, 25, 76, 37, 68, 99 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
System.Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);
System.Console.WriteLine();
