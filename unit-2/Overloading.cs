// Question:
// Demonstrate operator overloading in C#

using System;

namespace lab_work_1
{
    class Number
    {
        public int value;

        public Number(int v)
        {
            value = v;
        }

        // Overloading + operator
        public static Number operator +(Number a, Number b)
        {
            return new Number(a.value + b.value);
        }

        public void Display()
        {
            Console.WriteLine("Result: " + value);
        }
    }

    class Overloading
    {
        static void Main()
        {
            Number n1 = new Number(10);
            Number n2 = new Number(20);

            Number n3 = n1 + n2;  // overloaded operator

            n3.Display();

            Console.ReadLine();
        }
    }
}
