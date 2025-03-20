using System;

public static class MathUtils
{
    public static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative", nameof(n));

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
        int factorialInput = 5;
        Console.WriteLine($"Factorial of {factorialInput}: {Factorial(factorialInput)}");

        double baseNum = 2;
        int exponent = 5;
        Console.WriteLine($"{baseNum}^{exponent}: {Power(baseNum, exponent)}");

        int num1 = 48;
        int num2 = 18;
        Console.WriteLine($"GCD of {num1} and {num2}: {GCD(num1, num2)}");
    }
}
