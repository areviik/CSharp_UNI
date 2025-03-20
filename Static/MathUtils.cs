using System;

public static class MathUtils
{
    public static long Factorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static double Power(double baseNum, int exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    public static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }

    public static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int factorialInput = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factorial of {factorialInput}: {Factorial(factorialInput)}");

        Console.WriteLine("Enter base number for power calculation:");
        double baseNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter exponent:");
        int exponent = int.Parse(Console.ReadLine());
        Console.WriteLine($"{baseNum} raised to the power of {exponent}: {Power(baseNum, exponent)}");

        Console.WriteLine("Enter the first number to calculate GCD:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number to calculate GCD:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"GCD of {num1} and {num2}: {GCD(num1, num2)}");
    }
}
