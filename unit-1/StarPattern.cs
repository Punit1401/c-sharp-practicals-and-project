// Question:
// 7. Write C# code to display the asterisk pattern as shown below:
// ***** *****
// ***** ***** *****
// ***** ***** *****

using System;

class StarPattern
{
    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i + 1; j++)
            {
                Console.Write("***** ");
            }
            Console.WriteLine();
        }
    }
}
