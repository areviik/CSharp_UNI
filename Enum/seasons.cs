using System;

enum Season
{
    Winter,
    Spring, 
    Summer,
    Autumn
}
class Program
{
    static Season GetSeason(string month)
    {
        if (month == "December" || month == "January" || month == "February")
        {
            return Season.Winter;
        }
        if (month == "March" || month == "April" || month == "May")
        {
            return Season.Spring;
        }
        if (month == "June" || month == "July" || month == "August")
        {
            return Season.Summer;
        }
        if (month == "September" || month == "October" || month == "Novermber")
        {
            return Season.Autumn;
        }

        throw new Exception("Invalid month");
    }
        static void Main()
        {
            Console.Write("Enter the month: ");
            string month = Console.ReadLine();
            Season season = GetSeason(month);
            Console.WriteLine($"It's {season}");
        }
}