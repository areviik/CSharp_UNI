using System;

public class Celsius
{
    public double Value { get; set; }

    public Celsius(double value)
    {
        Value = value;
    }

    public static implicit operator Fahrenheit(Celsius celsius)
    {
        return new Fahrenheit(celsius.Value * 9 / 5 + 32);
    }

    public override string ToString()
    {
        return $"{Value}°C";
    }
}

public class Fahrenheit
{
    public double Value { get; set; }

    public Fahrenheit(double value)
    {
        Value = value;
    }

    public static explicit operator Celsius(Fahrenheit fahrenheit)
    {
        return new Celsius((fahrenheit.Value - 32) * 5 / 9);
    }

    public override string ToString()
    {
        return $"{Value}°F";
    }
}

class Program
{
    static void Main()
    {
        Celsius c = new Celsius(25);
        Console.WriteLine($"Initial value: {c}");

        Fahrenheit f = c;
        Console.WriteLine($"Celsius to Fahrenheit: {f}");

        Fahrenheit f2 = new Fahrenheit(77);
        Console.WriteLine($"Initial value: {f2}");

        Celsius c2 = (Celsius)f2;
        Console.WriteLine($"Fahrenheit to Celsius: {c2}");
    }
}