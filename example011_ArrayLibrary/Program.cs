// Работа с методами и массивом

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(5, 25);
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{array[position]}  ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;
    while (index < length)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Индекс искомого числа = {IndexOf(array,20)}");