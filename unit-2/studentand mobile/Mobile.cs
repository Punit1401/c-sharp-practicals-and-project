 class Mobile
    {
        public string model, manufacturer, owner;
        public double price;

        // Default Constructor
        public Mobile()
        {
            model = null;
            manufacturer = null;
            owner = null;
            price = 0;
        }

        // Parameterized Constructor
        public Mobile(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
        }

        // Static field for Nokia N95
        public static Mobile nokiaN95 = new Mobile("Nokia N95", "Nokia", 15000, "Default Owner");

        // Method to display mobile details
        public void Display()
        {
            Console.WriteLine("\n--- Mobile Details ---");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Manufacturer: " + manufacturer);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Owner: " + owner);
        }

        // Static method to display Nokia N95
        public static void ShowNokia()
        {
            Console.WriteLine("\n--- Static Mobile (Nokia N95) ---");
            Console.WriteLine("Model: " + nokiaN95.model);
            Console.WriteLine("Manufacturer: " + nokiaN95.manufacturer);
            Console.WriteLine("Price: " + nokiaN95.price);
            Console.WriteLine("Owner: " + nokiaN95.owner);
        }
    }
