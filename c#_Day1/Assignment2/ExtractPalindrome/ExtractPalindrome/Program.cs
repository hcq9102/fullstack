// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

// Method to check if a word is a palindrome
static bool IsPalindrome(string word)
{
    int len = word.Length;
    for (int i = 0; i < len / 2; i++)
    {
        if (char.ToLower(word[i]) != char.ToLower(word[len - 1 - i]))
        {
            return false;
        }
    }
    return true;
}


// Read the input text from the console
Console.WriteLine("Enter a text:");
string input = Console.ReadLine();

// Define a regular expression pattern to match words
string pattern = @"\b\w+\b";

// Find all words in the input text
MatchCollection matches = Regex.Matches(input, pattern);

// HashSet to store unique palindromes
HashSet<string> palindromes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

// Check each word for being a palindrome
foreach (Match match in matches)
{
    string word = match.Value;
    if (IsPalindrome(word))
    {
        palindromes.Add(word);
    }
}

// Sort the palindromes
List<string> sortedPalindromes = palindromes.ToList();
sortedPalindromes.Sort(StringComparer.OrdinalIgnoreCase);

// Print the sorted palindromes
Console.WriteLine("The extracted Palindromes from text: ");
Console.WriteLine(string.Join(", ", sortedPalindromes));

