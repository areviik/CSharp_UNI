using System;

class Program
{
    static void Main()
    {
        string[] students = { "Anna", "David" };

        string[][] studentSubjects = new string[][]
        {
            new string[] { "Mathematics", "Physics" },
            new string[] { "Chemistry" }
        };

        DateTime[][] examDates = new DateTime[][]
        {
            new DateTime[] { new DateTime(2025, 2, 15), new DateTime(2025, 2, 20) },
            new DateTime[] { new DateTime(2025, 2, 18) }
        };

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine($"Student: {students[i]}");
            for (int j = 0; j < studentSubjects[i].Length; j++)
            {
                Console.WriteLine($" Subject: {studentSubjects[i][j]}, Date: {examDates[i][j]:dd/MM/yyyy}");
            }
            Console.WriteLine();
        }
    }
}
