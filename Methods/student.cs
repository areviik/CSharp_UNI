using System;

class Program
{
    static void CalculateAverage(int[] grades, out double average)
    {
        CalcAverage(out average, grades);
    }

    static void UpdateGrade(ref int grade, int newGrade)
    {
        grade = newGrade;
    }

    static void DisplayGrades(string studentName, params int[] grades)
    {
        Console.WriteLine($"Student: {studentName}");
        Console.WriteLine("Grades: " + string.Join(", ", grades));
    }

    static void IsPassed(in double average)
    {
        Console.WriteLine(average >= 50 ? "Passed" : "Failed");
    }

    static void Main()
    {
        int gcd;
        FindGCD(42, 14, out gcd);
        Console.WriteLine($"The GCD of 42 and 14 is : " + gcd + "\n");

        int x = 11, y = 21;
        Swap(ref x, ref y);
        Console.WriteLine($"Swapped x = {x}, y = {y}\n");

        double avg;
        CalcAverage(out avg, 10, 20, 30);
        Console.WriteLine("Average is " + avg + "\n");

        int[] nums = { 1, 2, 3, 4, 5, 6 };
        Sum(nums);

        int num = 17;
        bool primeStatus;

        isPrime(in num, out primeStatus);
        Console.WriteLine($"{num} is {(primeStatus ? "a prime number" : "not a prime number")}\n");

        int randomValue;
        RandomNum(out randomValue);
        Console.WriteLine("Generated random number: " + randomValue + "\n");

        int[] numbers = { 5, 2, 6, 1, 3 };
        SortArray(ref numbers);
        Console.WriteLine("Sorted Array: " + string.Join(", ", numbers) + "\n");

        int maxValue;
        FindMax(out maxValue, 5, 12, 8, 20, 3);
        Console.WriteLine("Maximum Value: " + maxValue + "\n");

        string text = "Hello World!";
        int textLength;
        GetLength(in text, out textLength);
        Console.WriteLine($"The length of \"{text}\" is: {textLength}\n");

        string studentName = "Armen";
        int[] grades = { 60, 70, 50, 80 };
        DisplayGrades(studentName, grades);
        
        CalculateAverage(grades, out avg);
        UpdateGrade(ref grades[1], 75);

        Console.WriteLine("New grades after change: ");
        DisplayGrades(studentName, grades);
        CalculateAverage(grades, out avg);
        IsPassed(in avg);
    }
}