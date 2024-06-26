// See https://aka.ms/new-console-template for more information

/*
 *Question:
   Write a program that generates a random number between 1 and 3 and asks the user to
   guess what the number is. Tell the user if they guess low, high, or get the correct answer.
   Also, tell the user if their answer is outside of the range of numbers that are valid guesses
   (less than 1 or more than 3). You can convert the user's typed answer from a string to an
   int using this code:
 */

// Generate a random number between 1 and 3
Random random = new Random();
int correctNumber = random.Next(1, 4); // Next(1, 4) generates a number in range[1,4)

Console.WriteLine("Guess the number (between 1 and 3):");

// enter guess
int guessedNumber = int.Parse(Console.ReadLine());

// Check the guess
if (guessedNumber < 1 || guessedNumber > 3)
{
    Console.WriteLine("Your guess exceed the valid range(between 1 and 3). Please try again!");
}
else if (guessedNumber < correctNumber)
{
    Console.WriteLine("Your guess is smaller.");
}
else if (guessedNumber > correctNumber)
{
    Console.WriteLine("Your guess is bigger.");
}
else
{
    Console.WriteLine("Congrats! You got the right number.");
}

