using System;

namespace WeekdayEnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine("The day of the week is: " + (DayOfWeek)dayNumber);
            }
            else
            {
                Console.WriteLine("Invalid input:");
            }
        }
    }

    enum DayOfWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
