using System;
using System.Text;

class Program
{
    static void Main()
    {
        string[] input = { "Hello", " ", "World" };

        StringBuilder result = new StringBuilder();

        foreach (string str in input)
        {
            result.Append(str);
        }
        Console.WriteLine("Output: " + result.ToString());
    }
}

