using System;

enum TransactionType
{
    Deposit,
    Withdraw,
    Transfer
}

class Program
{
    static double PerformTransaction(double currentBalance, TransactionType transactionType, double amount)
    {

        switch (transactionType)
        {
            case TransactionType.Deposit:
                return currentBalance + amount;  
            case TransactionType.Withdraw:
                if (currentBalance >= amount)
                    return currentBalance - amount; 
                else
                    Console.WriteLine("You don't have enough balance to withdraw this amount.");
                return currentBalance;
            case TransactionType.Transfer:
                if (currentBalance >= amount)
                    return currentBalance - amount;  
                else
                    Console.WriteLine("You don't have enough balance to make the transfer.");
                return currentBalance;
            default:
                Console.WriteLine("Invalid transaction type.");
                return currentBalance;
        }
    }

    static void Main()
    {
        double currentBalance = 1000.00; 
        double amount;

        Console.WriteLine("Select transaction type: ");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Transfer");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the amount: ");
        amount = double.Parse(Console.ReadLine());

        TransactionType transactionType = (TransactionType)(choice - 1);

        double newBalance = PerformTransaction(currentBalance, transactionType, amount);
        Console.WriteLine($"New balance: {newBalance} currency.");
    }
}