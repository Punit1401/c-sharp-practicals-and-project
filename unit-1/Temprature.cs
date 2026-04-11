// 4. Perform Celsius to Fahrenheit Conversion and Fahrenheit to Celsius conversion.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double c = double.Parse(Console.ReadLine());
        double f = (c * 9 / 5) + 32;
        Console.WriteLine("Celsius to Fahrenheit: " + f);

        Console.Write("Enter temperature in Fahrenheit: ");
        double f2 = double.Parse(Console.ReadLine());
        double c2 = (f2 - 32) * 5 / 9;
        Console.WriteLine("Fahrenheit to Celsius: " + c2);
    }
}
