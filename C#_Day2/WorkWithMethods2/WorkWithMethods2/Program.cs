// See https://aka.ms/new-console-template for more information

using System;

class FibonacciSequence
{
    // Recursive method to calculate the nth Fibonacci number
    static int Fibonacci(int n)
    {
        // Base cases
        if (n == 1 || n == 2)
        {
            return 1;
        }
        // Recursive case
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void Main()
    {
        // Print the first 10 numbers of the Fibonacci sequence
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Fibonacci({i}) is : {Fibonacci(i)}");
        }
    }
}
