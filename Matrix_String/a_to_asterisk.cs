using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string userInput = Console.ReadLine();

        string result = userInput.Replace("a", "*");
        Console.WriteLine("Output: " + result);
    }
}

