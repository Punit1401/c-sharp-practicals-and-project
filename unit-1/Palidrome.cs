
// 5. Program to Check whether a number is Palindrome or not.

using System;

class Palidrome
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int original = num;
        int reverse = 0;

        while (num > 0)
        {
            int rem = num % 10;
            reverse = reverse * 10 + rem;
            num /= 10;
        }

        if (original == reverse)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome");
    }
}
