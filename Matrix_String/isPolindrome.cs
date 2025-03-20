using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string word = Console.ReadLine();

        string lowerInput = word.ToLower();
        char[] charArray = lowerInput.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        bool isPalindrome = lowerInput.Equals(reversed);

        Console.WriteLine("Output: " + isPalindrome);
    }
}
