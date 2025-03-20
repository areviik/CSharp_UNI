using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());  
        int[,] matrix = new int[N, N]; 

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < N; i++)  
        {
            for (int j = 0; j < N; j++) 
            {
                Console.Write($"Enter element at position [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());  
            }
        }
        int sum = 0;
        for (int i = 0; i < N; i++) 
        {
            sum += matrix[i, i];
        }
        Console.WriteLine("Sum of the main diagonal elements: " + sum);
    }
}