using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter element at position [{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> filteredList = new List<int>();

        foreach (var num in arr)
        {
            if (num % 2 == 0)
            {
                filteredList.Add(num);
            }
        }
        foreach (var num in filteredList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
