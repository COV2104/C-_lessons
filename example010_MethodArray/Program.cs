int []array = {15,26,54,78,12,36,45,79,25,46};
int n= array.Length;
int find = 36;
int index =0;
while(index<n)
{
    if(array[index]==find)
    {
        System.Console.WriteLine($"Индекс искомого числа = {index}");
        break;
    }
    index++;
}
