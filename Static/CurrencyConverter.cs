using System;

static class CurrencyConverter
{
    private static double exchangeRate = 0.91;

    public static double UsdToEur(double usd)
    {
        return usd * exchangeRate;
    }

    public static double EurToUsd(double eur)
    {
        return eur / exchangeRate;
    }
}

class Program
{
    static void Main()
    {
        double usd = 100;
        double eur = 100;

        Console.WriteLine($"{usd} USD = {CurrencyConverter.UsdToEur(usd):0.##} EUR");
        Console.WriteLine($"{eur} EUR = {CurrencyConverter.EurToUsd(eur):0.##} USD");
    }
}
