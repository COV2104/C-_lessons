﻿Console.Clear();
int xa = 50, ya = 1;
int xb = 1, yb = 40;
int xc = 100, yc = 40;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("*");
int x = xa;
int y = yb;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    else if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    else if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("*");
    count++;
}
