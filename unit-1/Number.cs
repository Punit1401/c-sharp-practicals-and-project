// Question:
// 9. C# Program to Count the Number of 1’s in the Entered Number.

using System;

class Number
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();

        int count = 0;

        foreach (char c in num)
        {
            if (c == '1')
                count++;
        }

        Console.WriteLine("Number of 1's: " + count);
    }
}
