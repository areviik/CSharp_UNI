//1

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello {userName}, next year you will be {userAge + 1} years old.");
    }
}