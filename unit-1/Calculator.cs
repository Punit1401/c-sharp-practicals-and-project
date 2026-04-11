// 6. Design a simple calculator using Switch Statement.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result: " + (a + b));
                break;
            case '-':
                Console.WriteLine("Result: " + (a - b));
                break;
            case '*':
                Console.WriteLine("Result: " + (a * b));
                break;
            case '/':
                Console.WriteLine("Result: " + (a / b));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
