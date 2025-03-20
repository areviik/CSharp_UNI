using System;

class Program
{
    static void isPrime(in int number, out bool isPrime)
    {
        isPrime = number > 1;
        for (int i = 2; i * i <= number && isPrime; i++)
        {
            if (number % i == 0) isPrime = false;
        }
    }
}