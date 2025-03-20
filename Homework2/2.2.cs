using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        
        Console.Write("Enter the size of jagged array: ");
        int rows = int.Parse(Console.ReadLine());
        
        long[][] steppedArray = new long[rows][];

        for (int i = 0; i < rows; i++)
        {
            int columns = random.Next(3, 7); 
            steppedArray[i] = new long[columns];

            for (int j = 0; j < columns; j++)
            {
                steppedArray[i][j] = DateTime.Now.Ticks; 
            }
        }

        Console.WriteLine("\nJagged Array with Time Ticks:");
        for (int i = 0; i < steppedArray.Length; i++)
        {
            Console.WriteLine($"{string.Join(" ", steppedArray[i])}");
        }
    }
}
