// Initialize the original array with 10 items
int[] originalArray = new int[10] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };

// Create new array with the same length as the original array
int[] copiedArray = new int[originalArray.Length];

// copy values from the original array to the new array
for (int i = 0; i < originalArray.Length; i++)
{
    copiedArray[i] = originalArray[i];
}

// Print the original array
Console.WriteLine("Original Array:");
foreach (int item in originalArray)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// Print the copied array
Console.WriteLine("Copied Array:");
foreach (int item in copiedArray)
{
    Console.Write(item + " ");
}
Console.WriteLine();

