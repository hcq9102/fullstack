List<string> itemList = new List<string>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
    string input = Console.ReadLine();

    if (input.StartsWith("+"))
    {
        if (input.Length > 2)
        {
            string item = input.Substring(2); // Extract item from input
            itemList.Add(item);
        }
        else
        {
            Console.WriteLine("Invalid command. Please enter an item after '+'.");
        }
    }
    else if (input.StartsWith("-"))
    {
        if (input.Length > 2)
        {
            string item = input.Substring(2); // Extract item from input
            itemList.Remove(item);
        }
        else if (input == "-" || input == "--")
        {
            itemList.Clear();
        }
        else
        {
            Console.WriteLine("Invalid command. Please enter an item after '-'.");
        }
    }
    else if (input == "--")
    {
        itemList.Clear();
    }
    else
    {
        Console.WriteLine("Invalid command.");
        continue; // Skip the rest of the loop and start over
    }

    // Show the current contents of the list
    Console.WriteLine("Current list:");
    foreach (string item in itemList)
    {
        Console.WriteLine("- " + item);
    }
    Console.WriteLine();
}
