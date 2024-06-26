// Read array from the console
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

// Variables to keep track of the longest sequence
int maxLen = 0;
int bestStart = 0;

int left = 0;

while (left < input.Length)
{
    int right = left;

    // Move right pointer to the end of the current sequence of equal elements
    while (right < input.Length && input[right] == input[left])
    {
        right++;
    }

    // Update maxLength and bestStart if a longer sequence is found
    if (right - left > maxLen)
    {
        maxLen = right - left;
        bestStart = left;
    }


    // Move left pointer to the start of the next sequence
    left = right;
}

// Print the longest sequence
Console.WriteLine("The longest sequence is: ");
for (int i = 0; i < maxLen; i++)
{
    Console.Write(input[bestStart] + " ");
}
