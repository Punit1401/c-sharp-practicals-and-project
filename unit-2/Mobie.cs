// Define a class Mobile with model, manufacturer, price, owner,
// battery features (model, idletime, talktime),
// and screen features (size, colors).

using System;

namespace lab_work_1
{
    class Battery
    {
        public string model;
        public int idleTime;
        public int talkTime;
    }

    class Screen
    {
        public double size;
        public int colors;
    }

    class Mobile
    {
        string model, manufacturer, owner;
        double price;

        Battery battery = new Battery();
        Screen screen = new Screen();

        public void GetData()
        {
            Console.Write("Enter Model: ");
            model = Console.ReadLine();

            Console.Write("Enter Manufacturer: ");
            manufacturer = Console.ReadLine();

            Console.Write("Enter Price: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("Enter Owner: ");
            owner = Console.ReadLine();

            Console.Write("Enter Battery Model: ");
            battery.model = Console.ReadLine();

            Console.Write("Enter Idle Time: ");
            battery.idleTime = int.Parse(Console.ReadLine());

            Console.Write("Enter Talk Time: ");
            battery.talkTime = int.Parse(Console.ReadLine());

            Console.Write("Enter Screen Size: ");
            screen.size = double.Parse(Console.ReadLine());

            Console.Write("Enter Number of Colors: ");
            screen.colors = int.Parse(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("\n--- Mobile Details ---");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Owner: " + owner);

            Console.WriteLine("\nBattery Info:");
            Console.WriteLine("Model: " + battery.model);
            Console.WriteLine("Idle Time: " + battery.idleTime);
            Console.WriteLine("Talk Time: " + battery.talkTime);

            Console.WriteLine("\nScreen Info:");
            Console.WriteLine("Size: " + screen.size);
            Console.WriteLine("Colors: " + screen.colors);
        }

        static void Main()
        {
            Mobile m = new Mobile();
            m.GetData();
            m.DisplayData();

            Console.ReadLine();
        }
    }
}
