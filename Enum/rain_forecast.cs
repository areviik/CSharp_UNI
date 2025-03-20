using System;

public class Program
{
    public enum WeatherCondition
    {
        Sunny,
        Cloudy,
        Rainy,
        Stormy
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("What's the weather today?");
        string input = Console.ReadLine();
        GiveAdvice(input);
    }

    static void GiveAdvice(string input)
    {
        switch (input.ToLower())
        {
            case "sunny":
                Console.WriteLine("Great day to go for a walk!");
                break;
            case "cloudy":
                Console.WriteLine("Put on a jacket to avoid getting sick!");
                break;
            case "rainy":
                Console.WriteLine("Don't forget your umbrella!");
                break;
            case "stormy":
                Console.WriteLine("Stay safe and indoors!");
                break;
            default:
                Console.WriteLine("Invalid weather condition.");
                break;
        }
    }
}