using System;

static class IDGenerator
{
    private static int currentID = 0;

    public static int GenerateID()
    {
        return ++currentID;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Generated ID: " + IDGenerator.GenerateID());
        Console.WriteLine("Generated ID: " + IDGenerator.GenerateID());
        Console.WriteLine("Generated ID: " + IDGenerator.GenerateID());
    }
}
