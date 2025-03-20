using System;

readonly struct Vector
{
    public int X { get; }
    public int Y { get; }

    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"Vector: ({X}, {Y})";
}

class Program
{
    static void Main()
    {
        Vector v = new Vector(2, 5);
        Console.WriteLine(v);
    }
}

