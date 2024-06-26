//increments from 1 to 4
for (int increment = 1; increment <= 4; increment++)
{
    // Inner loop: counts from 0 to 24, increasing by the value of the outer loop's control variable increment
    for (int i = 0; i <= 24; i += increment)
    {
        Console.Write(i);
        if (i + increment <= 24)
        {
            Console.Write(","); // Add a comma
        }
    }
    Console.WriteLine(); // new line
}

