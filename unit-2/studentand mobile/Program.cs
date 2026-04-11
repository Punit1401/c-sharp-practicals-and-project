using System;

namespace lab_work_1
{
  class Program
    {
        static void Main()
        {
            // Student objects
            Student s1 = new Student();
            Student s2 = new Student("Punit", "MCA");
            Student s3 = new Student("Rahul", "BCA", "Maths", "GTU", "rahul@gmail.com", "1234567890");

            s1.Display();
            s2.Display();
            s3.Display();

            // Mobile objects
            Mobile m1 = new Mobile();
            Mobile m2 = new Mobile("iPhone 15", "Apple", 80000, "Punit");

            m1.Display();
            m2.Display();

            // Display static Nokia N95
            Mobile.ShowNokia();

            Console.ReadLine();
        }
    }
}
