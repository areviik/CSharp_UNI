using System;
using static System.Console;

class UserAccount
{
    private string password;

    public string Password
    {
        set { password = value; }
    }

    public string MaskPass()
    {
        return password.Replace(password, new string('*', password.Length));
    }
}

class Program
{
    static void Main()
    {
        UserAccount user = new UserAccount();

        Console.Write("Enter your password: ");
        user.Password = Console.ReadLine();

        Console.WriteLine("Masked password: " + user.MaskPass());
    }
}