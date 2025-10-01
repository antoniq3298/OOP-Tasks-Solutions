using System;
using System.Collections.Generic;

class Program
{
    static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            stack.Push(c);
        }

        char[] reversed = new char[input.Length];
        int index = 0;

        while (stack.Count > 0)
        {
            reversed[index++] = stack.Pop();
        }

        return new string(reversed);
    }

    static void Main()
    {
        string text = "Interview";
        string reversed = ReverseString(text);
        Console.WriteLine($"Original: {text}");
        Console.WriteLine($"Reversed: {reversed}");
    }
}
