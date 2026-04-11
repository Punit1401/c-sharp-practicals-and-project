// 1. Find the sum of all the elements present in a jagged array of 3 inner arrays.

using System;

class Program
{
    static void Main()
    {
        int[][] arr = new int[3][];

        arr[0] = new int[] { 1, 2, 3 };
        arr[1] = new int[] { 4, 5 };
        arr[2] = new int[] { 6, 7, 8, 9 };

        int sum = 0;

        foreach (int[] inner in arr)
        {
            foreach (int num in inner)
            {
                sum += num;
            }
        }

        Console.WriteLine("Sum of all elements: " + sum);
    }
}
