// Question:
// 10. C# program to generate Random Numbers.

using System;

class RandomNumber
{
    static void Main()
    {
        Random rnd = new Random();

        Console.WriteLine("Random Numbers:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(rnd.Next(1, 100));
        }
    }
}
