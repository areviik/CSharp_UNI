using System;

class User
{
    private static int userCount = 0;

    public User()
    {
        userCount++;
    }

    public static int GetUserCount()
    {
        return userCount;
    }
}

class Program
{
    static void Main()
    {
        User user1 = new User();
        User user2 = new User();
        User user3 = new User();

        Console.WriteLine("User count: " + User.GetUserCount());
    }
}
