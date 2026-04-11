// Question:
// 8. Prompt user to input name and country and display:
// Hello Shyam from country India!

using System;

class Message
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your country: ");
        string country = Console.ReadLine();

        Console.WriteLine("Hello " + name + " from country " + country + "!");
    }
}
