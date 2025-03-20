using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a mathematical expression or press Q to exit: ");
            string userInput = Console.ReadLine();

            if (userInput.Equals("Q", StringComparison.OrdinalIgnoreCase))
                break;

            char[] mathOperators = { '+', '-', '*', '/', '=' };
            string[] expressionParts = userInput.Split(mathOperators, StringSplitOptions.RemoveEmptyEntries);

            if (expressionParts.Length < 2)
            {
                Console.WriteLine("The expression must include more than two elements.\n");
                continue;
            }

            double calculationResult = Convert.ToDouble(expressionParts[0]);

            char operatorChar = userInput[userInput.IndexOfAny(mathOperators)];

            for (int i = 1; i < expressionParts.Length; i++)
            {
                double number = Convert.ToDouble(expressionParts[i]);

                switch (operatorChar)
                {
                    case '+':
                        calculationResult += number;
                        break;
                    case '-':
                        calculationResult -= number;
                        break;
                    case '*':
                        calculationResult *= number;
                        break;
                    case '/':
                        if (number == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.\n");
                            break;
                        }
                        calculationResult /= number;
                        break;
                    default:
                        Console.WriteLine("Invalid operator.\n");
                        break;
                }
            }

            Console.WriteLine($"Result: {calculationResult}\n");

            ConsoleKey key = Console.ReadKey().Key;
            if (key == ConsoleKey.Q)
                break;

            Console.WriteLine(); 
        }

        Console.WriteLine("\nProgram exited!");
    }
}
