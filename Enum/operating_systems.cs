using System;
enum OperatingSystem
{
    Windows,
    MacOS,
    Linux
}
class Program
{
    static void PrintList(OperatingSystem os)
    {
        switch(os)
        {
            case OperatingSystem.Windows:
                Console.Write("Apps in Windows: ");
                Console.Write("Microsoft office, Visual Studio, WinRAR, Steam\n");
                break;
            case OperatingSystem.MacOS:
                Console.Write("Apps in MacOS: ");
                Console.Write("Apple Office Suite, Xcode, Final Cut Pro, Safari\n");
                break;
            case OperatingSystem.Linux:
                Console.Write("Apps in Linux: ");
                Console.Write("LibreOffice, GIMP, Media Player, Steam\n");
                break;
            default:
                Console.Write("Unknown operating system");
                break;
        }
    }

    static void Main()
    {
        OperatingSystem currOs = OperatingSystem.Windows;
        PrintList(currOs);
    }
}