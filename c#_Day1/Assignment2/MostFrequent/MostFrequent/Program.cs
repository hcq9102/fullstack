// map<>
int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
var counts = new Dictionary<int, int>();
foreach (int number in numbers) {
    int count;
    //counts[number] = counts.GetValueOrDefault(number, 0) + 1
    counts.TryGetValue(number, out count);
    count++;
    //Automatically replaces the entry if it exists;
    counts[number] = count;
}
int mostCommonNumber = 0, occurrences = 0;
foreach (var pair in counts) {
    if (pair.Value > occurrences ) {
        occurrences = pair.Value;
        mostCommonNumber = pair.Key;
    }
}
Console.WriteLine ("The most common number is {0}",
    mostCommonNumber);


// bucket

//
// // Read the sequence of numbers from the console
// int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
//
// // Find the maximum number in the sequence
// int maxNumber = numbers.Max();
//
// // Create an array to store the frequency of each number
// int[] frequencyArray = new int[maxNumber + 1];
//
// // Create an array to store the index of the first occurrence of each number
// int[] firstOccurrenceIndex = new int[maxNumber + 1];
//
// // Initialize the first occurrence index array with -1
// for (int i = 0; i <= maxNumber; i++)
// {
//     firstOccurrenceIndex[i] = -1;
// }
//
// // Count the frequency of each number and record its first occurrence index
// for (int i = 0; i < numbers.Length; i++)
// {
//     int num = numbers[i];
//     if (firstOccurrenceIndex[num] == -1)
//     {
//         firstOccurrenceIndex[num] = i;
//     }
//     frequencyArray[num]++;
// }
//
// // Find the most frequent number(s) with the leftmost occurrence
// int maxFrequency = frequencyArray.Max();
// int mostFrequentNumber = -1; // Initialize to an invalid value
//
// foreach (int num in numbers)
// {
//     if (frequencyArray[num] == maxFrequency && (mostFrequentNumber == -1 || firstOccurrenceIndex[num] < firstOccurrenceIndex[mostFrequentNumber]))
//     {
//         mostFrequentNumber = num;
//     }
// }
//
// // Print the result
// Console.WriteLine(mostFrequentNumber);
