// Question:
// 2. Find largest number from 3 numbers passed using command line argument.

using System;

class Find_largest_number
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Please pass 3 numbers as arguments.");
            return;
        }

        int a = int.Parse(args[0]);
        int b = int.Parse(args[1]);
        int c = int.Parse(args[2]);

        int largest = a;

        if (b > largest) largest = b;
        if (c > largest) largest = c;

        Console.WriteLine("Largest number is: " + largest);
    }
}
