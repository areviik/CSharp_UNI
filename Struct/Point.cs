using System;

class Program
{
    struct Point
    {
        public readonly int X, Y;

        public Point(int Xpos, int Ypos)
        {
            X = Xpos;
            Y = Ypos;
        }
        public readonly void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
        static void Main()
        {
            Point p = new Point(3, 4);
            p.Display();
        }
}