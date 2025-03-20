using System;

Console.Write("Enter rectangle's width = ");
int width = int.Parse(Console.ReadLine());

Console.Write("Enter rectangle's height = ");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("\nDrawing the rectangle:");

for (int row = 0; row < height; row++)
{
    int colorIndex = 0;
    for (int col = 0; col < width; col++)
    {
        Console.ForegroundColor = (ConsoleColor)colorIndex;
        Console.Write("*");
        colorIndex = (colorIndex + 1) % 16;
    }
    Console.WriteLine();
}

Console.ResetColor();