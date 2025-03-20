using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the line: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Console.WriteLine("Output: ");
        foreach (string word in words)
        {
            foreach (char c in word)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}