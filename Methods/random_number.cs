using System;

class Program
{
    static void RandomNum(out int num)
    {
        Random rand = new Random();
        num = rand.Next(1, 101);
    }
}