using System;

class Account
{
    public double Balance { get; set; }

    public Account(double balance)
    {
        Balance = balance;
    }

    public virtual double CalculateInterest()
    {
        return 0;
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(double balance) : base(balance) { }

    public override double CalculateInterest()
    {
        return 0.05 * Balance;
    }
}

class CurrentAccount : Account
{
    public CurrentAccount(double balance) : base(balance) { }

    public override double CalculateInterest()
    {
        return 0.02 * Balance;
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount(1000);
        CurrentAccount current = new CurrentAccount(1000);

        Console.WriteLine($"SavingsAccount: {savings.CalculateInterest()}");
        Console.WriteLine($"CurrentAccount: {current.CalculateInterest()}");
    }
}
