using System;

class Program
{
    static void Main()
    {
        string[][] Groups = new string[3][];
        Groups[0] = new string[] { "Ann", "Tom" };
        Groups[1] = new string[] { "Alice", "David" };
        Groups[2] = new string[] { "Jonathan", "Catherine" };

        for (int i = 0; i < Groups.Length; i++)
        {
            Console.Write($"Name group {i + 1}: ");

            for (int j = 0; j < Groups[i].Length; j++)
            {
                Console.Write(Groups[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}


