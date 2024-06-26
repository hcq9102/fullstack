// See https://aka.ms/new-console-template for more information

//1.FizzBuzz game

// Loop through numbers from 1 to 100
for (int i = 1; i <= 100; i++)
{
    // Check if the number is divisible by both 3 and 5
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    // Check if the number is divisible by 3
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    // Check if the number is divisible by 5
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    // If the number is not divisible by 3 or 5, print the number itself
    else
    {
        Console.WriteLine(i);
    }
}
