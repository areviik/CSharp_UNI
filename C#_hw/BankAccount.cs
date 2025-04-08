using System;
using static System.Console;

class BankAccount
{
    private float balance;

    public float Balance
    {
        get
        {
            return balance;
        }
        set
        {
            if (value < 0)
            {
                WriteLine("Balance cannot be negative!");
            }
            balance = value;
        }
    }

    public BankAccount(float initialBalance)
    {
        Balance = initialBalance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount obj = new BankAccount(12000);
        WriteLine("Users balance: {0}", obj.Balance);
        obj.Balance = -34;
    }
}