using System;

public static class Statistics
{
    public static double FindAverage(int[] numbers)
    {
        double sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum / numbers.Length;
    }

    public static int FindMin(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new ArgumentException("Array cannot be empty.", nameof(numbers));

        int min = numbers[0];
        foreach (var num in numbers)
        {
            if (num < min)
                min = num;
        }

        return min;
    }

    public static int FindMax(int[] numbers)
    {
        if (numbers.Length == 0)
            throw new ArgumentException("Array cannot be empty.", nameof(numbers));

        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
                max = num;
        }

        return max;
    }

    public static void Main()
    {
        int[] numbers = { 3, 1, 7, 5, 4, 2 };

        Console.WriteLine($"Average: {FindAverage(numbers)}");
        Console.WriteLine($"Min: {FindMin(numbers)}");
        Console.WriteLine($"Max: {FindMax(numbers)}");
    }
}
