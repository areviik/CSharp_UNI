using System;
using static System.Console;

class Rectangle
{
    private int width;
    private int height;

    public int Width
    {
        get { return width; }
        set 
        {
            width = value > 0 ? value : 10; 
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            height = value > 0 ? value : 20;
        }
    }

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }
    public int Area() => width * height;
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(12, 20);
        WriteLine("Rectangle area: {0}",rect.Area());
        rect.Height = -1;
        rect.Width = -1;
        WriteLine("Rectangle area: {0}", rect.Area());
    }
}