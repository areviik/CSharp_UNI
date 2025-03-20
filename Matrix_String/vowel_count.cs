using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string userInput = Console.ReadLine();

        string vowels = "aeiouAEIOU";
        int vowelCount = 0;
        foreach (char c in userInput)
        {
            if (vowels.Contains(c))
            {
                vowelCount++;
            }
        }
        Console.WriteLine("Output: " + vowelCount);
    }
}
