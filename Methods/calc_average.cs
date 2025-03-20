using System;

class Program
{
    static void CalcAverage(out double average, params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }
        average = (double)sum / numbers.Length;
    }
}