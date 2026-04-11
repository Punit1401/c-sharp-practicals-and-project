// Question:
// 3. Write C# code to do the following:
// - Convert binary to decimal
// - Convert decimal to hexadecimal
// - Convert decimal to binary
// - Convert decimal to octal

using System;

class Converstion
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();
        int decimalFromBinary = Convert.ToInt32(binary, 2);
        Console.WriteLine("Binary to Decimal: " + decimalFromBinary);

        Console.Write("Enter a decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine());

        string hex = decimalNum.ToString("X");
        Console.WriteLine("Decimal to Hexadecimal: " + hex);

        string bin = Convert.ToString(decimalNum, 2);
        Console.WriteLine("Decimal to Binary: " + bin);

        string oct = Convert.ToString(decimalNum, 8);
        Console.WriteLine("Decimal to Octal: " + oct);
    }
}
