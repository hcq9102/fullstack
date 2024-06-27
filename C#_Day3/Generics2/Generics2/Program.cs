
/*
 2. Create a Generic List data structure MyList<T> that can store any data type.
   Implement the following methods.
       1. void Add (T element)
       2. T Remove (int index)
       3. bool Contains (T element)
       4. void Clear ()
       5. void InsertAt (T element, int index)
       6. void DeleteAt (int index)
       7. T Find (int index)
    */
using System;
using System.Collections.Generic;
using Generics2;

Console.WriteLine("Int case test: \n");
MyList<int> intList = new MyList<int>();
intList.Add(1);
intList.Add(2);
intList.Add(3);
Console.WriteLine("Contains 2: " + intList.Contains(2)); // Output: Contains 2: True
Console.WriteLine("Find at index 1: " + intList.Find(1)); // Output: Find at index 1: 2
intList.InsertAt(4, 1);
Console.WriteLine("Find at index 1: " + intList.Find(1)); // Output: Find at index 1: 4
intList.DeleteAt(1);
Console.WriteLine("Contains 4: " + intList.Contains(4)); // Output: Contains 4: False
intList.Clear();
Console.WriteLine("Count after clear: " + intList.Count()); // Output: Count after clear: 0

Console.WriteLine("String case test: \n");
// string test
MyList<string> stringList = new MyList<string>();
stringList.Add("Your");
stringList.Add("Name");
Console.WriteLine("Contains 'Name': " + stringList.Contains("Name")); // Output: Contains 'Name': True
Console.WriteLine("Find at index 0: " + stringList.Find(0)); // Output: Find at index 0: Hello
stringList.Remove(0);
Console.WriteLine("Contains 'Your': " + stringList.Contains("Your")); // Output: Contains 'Your': False
stringList.Clear();
Console.WriteLine("Count after clear: " + stringList.Count()); // Output: Count after clear: 0
