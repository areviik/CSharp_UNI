using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a mathematical expression: ");
            string userInput = Console.ReadLine();

            char[] mathOperators = { '+', '-', '*', '/', '=' };
            string[] expressionParts = userInput.Split(mathOperators, StringSplitOptions.RemoveEmptyEntries);

            if (expressionParts.Length < 2)
            {
                Console.WriteLine("The expression must include more than two elements.\n");
            }
            else
            {
                double result = Convert.ToDouble(expressionParts[0]);
                char operatorChar = userInput[userInput.IndexOfAny(mathOperators)];

                for (int i = 1; i < expressionParts.Length; i++)
                {
                    double num = Convert.ToDouble(expressionParts[i]);

                    switch (operatorChar)
                    {
                        case '+':
                            result += num;
                            break;
                        case '-':
                            result -= num;
                            break;
                        case '*':
                            result *= num;
                            break;
                        case '/':
                            if (num == 0)
                            {
                                Console.WriteLine("Cannot divide by zero.\n");
                                break;
                            }
                            result /= num;
                            break;
                        default:
                            Console.WriteLine("Invalid operator.\n");
                            break;
                    }
                }

                Console.WriteLine($"Result: {result}\n");
            }
        }
    }
}
