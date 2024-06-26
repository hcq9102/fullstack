using System;
// method1: Convert the string to char array, reverse it, then convert it to string again

// 从控制台读取字符串
Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

// 将字符串转换为字符数组
char[] charArray = input.ToCharArray();

// 反转字符数组
Array.Reverse(charArray);

// 将反转后的字符数组转换回字符串
string reversedString = new string(charArray);

// 打印反转后的字符串
Console.WriteLine("Reversed string (method 1): " + reversedString);
