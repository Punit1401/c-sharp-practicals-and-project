// Define a class Student, which contains the following information
// about students: full name, course, subject, university, e-mail and
// phone_number. Add two methods to collect and display information.

using System;

namespace lab_work_1
{
    class Student
    {
        string fullName, course, subject, university, email, phoneNumber;
        public void GetData()
        {
            Console.Write("Enter Full Name: ");
            fullName = Console.ReadLine();

            Console.Write("Enter Course: ");
            course = Console.ReadLine();

            Console.Write("Enter Subject: ");
            subject = Console.ReadLine();

            Console.Write("Enter University: ");
            university = Console.ReadLine();

            Console.Write("Enter Email: ");
            email = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            phoneNumber = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + fullName);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("University: " + university);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone Number: " + phoneNumber);
        }

        static void Main()
        {
            Student s = new Student();
            s.GetData();
            s.DisplayData();

            Console.ReadLine();
        }
    }
}
