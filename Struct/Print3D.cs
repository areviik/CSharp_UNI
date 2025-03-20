using System;

readonly struct Point3D
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double DistanceFromOrigin()
    {
        return Math.Sqrt(X * X + Y * Y + Z * Z);
    }
}

class Program
{
    static void Main()
    {
        Point3D p3d = new Point3D(5, 5, 3);
        Console.WriteLine($"Distance: {p3d.DistanceFromOrigin():F2}");
    }
}
