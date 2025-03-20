using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string result = input.Replace(" ", "");
        Console.WriteLine("Output: " + result);
    }
}
