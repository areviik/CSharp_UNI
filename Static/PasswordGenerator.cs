using System;
using System.Text;

public static class PasswordGenerator
{
    private static readonly string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;:,.<>?";

    public static string GeneratePassword(int length)
    {
        if (length <= 0)
            throw new ArgumentException("Password length must be greater than zero.", nameof(length));

        Random random = new Random();
        StringBuilder password = new StringBuilder(length);

        for (int i = 0; i < length; i++)
        {
            char randomChar = ValidChars[random.Next(ValidChars.Length)];
            password.Append(randomChar);
        }

        return password.ToString();
    }
}
class Program
{
    static void Main()
    {
        string password = PasswordGenerator.GeneratePassword(12);
        Console.WriteLine($"Generated Password: {password}");
    }
}


