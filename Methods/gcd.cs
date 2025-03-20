using System;

class Program
{
    static void FindGCD(int a, int b, out int gcd)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        gcd = a;
    }
}