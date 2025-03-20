using System;

class Program
{
    static void FindMax(out int max, params int[] numbers)
    {
        max = numbers[0];
        foreach (int num in numbers)
            if (num > max) max = num;
    }
}