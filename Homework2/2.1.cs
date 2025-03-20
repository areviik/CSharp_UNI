using System;

class Program
{
    static void Main()
    {
        string[] colorNames = new string[]
        {
            "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta",
            "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta",
            "Yellow", "White"
        };

        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        string[,] colorsArray = new string[size, 2];

        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            int randomIndex = rand.Next(colorNames.Length);
            colorsArray[i, 0] = colorNames[randomIndex];
        }

        for (int i = 0; i < size; i++)
        {
            switch (colorsArray[i, 0])
            {
                case "Black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "DarkBlue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "DarkGreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "DarkCyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "DarkRed":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "DarkMagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "DarkYellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "DarkGray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine(colorsArray[i, 0]);
        }

        Console.ResetColor();
    }
}

