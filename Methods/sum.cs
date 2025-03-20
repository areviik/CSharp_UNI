using System;

class Program
{
    static void Sum(params int[] numbers)
    {
        int res = 0;
        foreach (int n in numbers)
        {
            res += n;
        }
        Console.WriteLine("The sum is: " + res + "\n");
    }
}