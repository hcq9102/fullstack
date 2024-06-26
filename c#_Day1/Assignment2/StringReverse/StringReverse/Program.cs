// See https://aka.ms/new-console-template for more information

//----- method 1------
//Convert the string to char array, reverse it, then convert it to string again
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

char[] charArray = input.ToCharArray();

Array.Reverse(charArray);

string reversedString = new string(charArray);
Console.WriteLine("Reversed string (method 1): " + reversedString);



// ------ method2---------
//Print the letters of the string in back direction (from the last to the first) in a for-loop
Console.WriteLine("Enter a string:");
string input2 = Console.ReadLine();

// for loop
Console.Write("Reversed string (method 2): ");
for (int i = input2.Length - 1; i >= 0; i--)
{
    Console.Write(input2[i]);
}
Console.WriteLine();
