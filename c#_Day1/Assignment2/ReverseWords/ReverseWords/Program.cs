// See https://aka.ms/new-console-template for more information
// Read input sentence from the console
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

Console.WriteLine("Enter a sentence:");
string input = Console.ReadLine();

// Define the separators
string pattern = @"([.,:;=\(\)&\[\]""'\\/!? ]+)";

// Split the input into words and separators
List<string> parts = new List<string>();
foreach (string part in Regex.Split(input, pattern))
{
    if (part != string.Empty)
    {
        parts.Add(part);
    }
}

// Identify the words and separators
List<string> words = new List<string>();
List<string> separators = new List<string>();

foreach (string part in parts)
{
    if (Regex.IsMatch(part, pattern))
    {
        separators.Add(part);
    }
    else
    {
        words.Add(part);
    }
}

// Reverse the words list
words.Reverse();

// Reconstruct the sentence
string result = "";
int wordIndex = 0;
int separatorIndex = 0;

// Iterate through parts to reconstruct the sentence
foreach (string part in parts)
{
    if (Regex.IsMatch(part, pattern))
    {
        result += separators[separatorIndex++];
    }
    else
    {
        result += words[wordIndex++];
    }
}

// Print the result
Console.WriteLine("The reversed sentence is:");
Console.WriteLine(result);
