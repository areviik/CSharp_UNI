using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }
}