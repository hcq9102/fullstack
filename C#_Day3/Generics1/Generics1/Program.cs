// See https://aka.ms/new-console-template for more information
/*
 * Practice working with Generics
   1. Create a custom Stack class MyStack<T> that can be used with any data type which
   has following methods
       1. int Count()
       2. T Pop()
       3. Void Push()
 *
 *
 */
using Generics1;

// test generic1

MyStack<int> intStack = new MyStack<int>();
// operation on int type
intStack.Push(1);
intStack.Push(2);
intStack.Push(3);
Console.WriteLine("int stack Count: " + intStack.Count()); // Output: Count: 3
Console.WriteLine("Popped: " + intStack.Pop());  // Output: Popped: 3
Console.WriteLine("Count: " + intStack.Count()); // Output: Count: 2

Console.WriteLine("\n ");

// operation on strings
MyStack<string> stringStack = new MyStack<string>();
stringStack.Push("Your");
stringStack.Push("Name");
Console.WriteLine("string stack Count: " + stringStack.Count()); // Output: Count: 2
Console.WriteLine("Popped: " + stringStack.Pop());  // Output: Popped:Name
Console.WriteLine("Count: " + stringStack.Count()); // Output: Count: 1
