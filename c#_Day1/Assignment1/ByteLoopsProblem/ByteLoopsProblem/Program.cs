// See https://aka.ms/new-console-template for more information

/* Question:
   Create a console application and enter the preceding code. Run the console application
   and view the output. What happens?
   What code could you add (don’t change any of the preceding code) to warn us about the
   problem
*/
int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}
//What will happen if this code executes?
/*Answer:
 *  It will run into an infinite loop.
 *  Due to i is declared as a byte,which has a maximum value of 255.
 *  Therefore, the loop condition i < max will never be false.
 * Once i reaches 255 and is incremented, it will wrap around to 0 due to overflow,
 * and the condition i < max will always be true.
 */



// modify as following:
//Solution:add a conditional statement to check if i has reached its maximum value and then break out of the loop.
int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
    if (i == byte.MaxValue) // Check if i has reached its maximum value
    {
        Console.WriteLine("Warning: i has reached its maximum value. Exiting loop.");
        break;
    }
}
