using System;

class Program
{
    static void Main()
    {
        ConsoleColor[][] colors = new ConsoleColor[][]
        {
            new ConsoleColor[] { ConsoleColor.Red },
            new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Blue },
            new ConsoleColor[] { ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Magenta }
        };

        foreach (ConsoleColor[] row in colors)
        {
            foreach (ConsoleColor color in row)
            {
                Console.ForegroundColor = color;
                Console.Write(color + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
