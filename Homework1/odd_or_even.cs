//3

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int inputNum))
        {
            if (inputNum < 0)
            {
                Console.WriteLine("The entered number is negative, please enter a positive number.");
            }
            else if (inputNum % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a numeric value.");
        }
    }
}