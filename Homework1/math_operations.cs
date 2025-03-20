//2

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        var firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        var secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine($"Sum: {firstNum + secondNum}");
        Console.WriteLine($"Difference: {firstNum - secondNum}");
        Console.WriteLine($"Product: {firstNum * secondNum}");
        Console.WriteLine($"Quotient: {(secondNum != 0 ? (firstNum / secondNum).ToString("F4") : "Undefined")}");
    }
}