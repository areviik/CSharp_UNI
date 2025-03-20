using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string word = Console.ReadLine();

        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);

        string reversed = new string(charArray);
        Console.WriteLine("Output: " + reversed);
    }
}


