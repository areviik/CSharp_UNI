using System;

enum ColorMode
{
    RGB,
    CMYK,
    Grayscale
}

class Program
{ 
    static void PrintColorModeDescription(ColorMode colorMode)
    {
        switch (colorMode)
        {
            case ColorMode.RGB:
                Console.WriteLine("The RGB (Red, Green, Blue) color model uses three primary colors: red, green, and blue. By combining these colors, other colors can be created.");
                break;
            case ColorMode.CMYK:
                Console.WriteLine("The CMYK (Cyan, Magenta, Yellow, Black) color model is mainly used in printing, where dark colors are made by combining cyan, magenta, yellow, and black.");
                break;
            case ColorMode.Grayscale:
                Console.WriteLine("The Grayscale color model uses only shades of gray, ranging from black to white. It is commonly used in black-and-white images.");
                break;
            default:
                Console.WriteLine("Invalid color mode.");
                break;
        }
    }

    static void Main()
    {
        Console.WriteLine("Choose a color mode:");
        Console.WriteLine("1. RGB");
        Console.WriteLine("2. CMYK");
        Console.WriteLine("3. Grayscale");
        int choice = int.Parse(Console.ReadLine());

        ColorMode colorMode = (ColorMode)(choice - 1);

        PrintColorModeDescription(colorMode);
    }
}