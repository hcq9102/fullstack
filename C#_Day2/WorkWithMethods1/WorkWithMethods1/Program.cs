// See https://aka.ms/new-console-template for more information

using System;

// Define a class named ReverseArray
class ReverseArray
{
    // Define  GenerateNumbers method that take desired length of array
    public static int[] GenerateNumbers(int len)
    {
        Random random = new Random();
        int[] numbers = new int[len];

        for (int i = 0; i < len; i++)
        {
            numbers[i] = random.Next(1, 101); // Generate random numbers between 1 and 100
        }

        return numbers;
    }

    // Define Reverse method
    public static void Reverse(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n/2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
    }

    public static void PrintNumbers(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // Main method
    public static void Main()
    {
        int n = 10;
        int[] numbers = GenerateNumbers(n);
        Console.Write("origin array: \n");
        PrintNumbers(numbers);

        Reverse(numbers);

        Console.Write("Reversed array: \n");
        PrintNumbers(numbers);

    }
}
