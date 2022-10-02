// Найти максимум из 9 чисел.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 36;
int b1 = 455;
int c1 = 5;

int a2 = 561;
int b2 = 85;
int c2 = 3;

int a3 = 23;
int b3 = 12;
int c3 = 78;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));

Console.WriteLine($"Максимум = {max}");