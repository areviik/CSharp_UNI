using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        char[] charArray = word.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] >= 'a' && charArray[i] <= 'z')
            {
                charArray[i] = (char)(charArray[i] - 32);
            }
        }
        Console.WriteLine(new string(charArray));
    }
}

