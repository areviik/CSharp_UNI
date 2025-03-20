using System;

static class SunCalculator
{
    private static int totalCalculations = 0;

    public static int Sum(int a, int b)
    {
        totalCalculations++;
        return a + b;
    }

    public static int GetTotalCalculations()
    {
        return totalCalculations;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Sum: " + SunCalculator.Sum(3, 5));
        Console.WriteLine("Sum: " + SunCalculator.Sum(7, 8));
        Console.WriteLine("Total Calculations: " + SunCalculator.GetTotalCalculations());
    }
}
