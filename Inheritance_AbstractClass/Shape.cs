using System;

abstract class Shape
{
    public abstract double CalculateArea();
}

class Rectangle : Shape
{
    public double Width {  get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width; 
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Shape rectangle = new Rectangle(4,5);
        Shape circle = new Circle(2);
        Console.WriteLine($"Area of the Rectangle is: {rectangle.CalculateArea()}");
        Console.WriteLine($"Area of the Circle is: {circle.CalculateArea()}");
    }
}