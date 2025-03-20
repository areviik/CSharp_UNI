using System;
using System.Threading;

class Program
{
    struct Position
    {
        public int posX;
        public int posY;

        public Position(int x, int y)
        {
            posX = x;
            posY = y;
        }
    }

    static void Draw(Position pos, char character)
    {
        Console.SetCursorPosition(pos.posX, pos.posY);
        Console.Write(character);
    }

    static void Motion(ref Position pos, char character, int endX, int speed)
    {
        while (pos.posX <= endX)
        {
            Console.Clear();
            Draw(pos, character);
            pos.posX++;
            Thread.Sleep(speed);
        }
    }

    static void Main()
    {
        char character = '*';
        Position pos = new Position(0, 5);
        int endX = 50;
        int speed = 200;

        Motion(ref pos, character, endX, speed);
    }
}