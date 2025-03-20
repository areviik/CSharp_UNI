//5

using System;
class Program
{
    static void Main()
    {
        string[] userNames = { "Ani", "Arman", "Nare", "David" };
        int[] userAges = { 20, 17, 22, 19 };

        Console.Write("Do you want to display user data? (yes/no): ");
        string userChoice = Console.ReadLine().ToLower();

        if (userChoice == "yes")
        {
            for (int i = 0; i < userNames.Length; i++)
            {
                string userStatus = userAges[i] >= 18 ? "an adult" : "not an adult";
                Console.WriteLine($"{userNames[i]} - {userAges[i]} years old - {userStatus}");
            }
        }
        else
        {
            Console.WriteLine("Data will not be displayed.");
        }
    }
}