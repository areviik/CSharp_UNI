using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the line: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        char[][] revarr = new char[words.Length][];
        for (int i = 0; i < words.Length; i++)
        {
            revarr[i] = words[i].ToCharArray();
            Array.Reverse(revarr[i]);
        }
        Console.WriteLine("Output: ");
        for (int i = 0;i < words.Length;i++)
        {
            Console.WriteLine($"Initial word {words[i]} -> Reversed word {new string(revarr[i])}");
        }
    }
}

