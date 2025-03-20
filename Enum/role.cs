using System;

public class Program
{
    public static void Main(string[] args)
    {
        UserRole[] roles = { UserRole.Guest, UserRole.User, UserRole.Moderator, UserRole.Admin };
        for (int i = 0; i < roles.Length; i++)
        {
            Console.Write($"Permission access: ");
            AskForInput(roles[i]);
        }
    }

    static void AskForInput(UserRole ur)
    {
        switch (ur)
        {
            case UserRole.Guest:
                Console.WriteLine("You don't have the right to entry!");
                break;
            case UserRole.User:
                Console.WriteLine("You can read!");
                break;
            case UserRole.Moderator:
                Console.WriteLine("You can edit!");
                break;
            case UserRole.Admin:
                Console.WriteLine("You can do everything!");
                break;
        }
    }

    enum UserRole
    {
        Guest,
        User = 1,
        Moderator,
        Admin
    }
}