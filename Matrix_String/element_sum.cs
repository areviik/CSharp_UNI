using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        Console.WriteLine("Enter matrix elements:");
        string[] input = Console.ReadLine().Split();
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(input[i]);
            sum += array[i];
        }
        Console.WriteLine("Sum of the elements is: " + sum);
    }
}

