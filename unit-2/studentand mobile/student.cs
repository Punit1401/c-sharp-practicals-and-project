using System;

namespace lab_work_1
{
    // ------------------- Student Class -------------------
    class Student
    {
        string name, course, subject, university, email, phone;

        // Default Constructor
        public Student()
        {
            name = null;
            course = null;
            subject = null;
            university = null;
            email = null;
            phone = null;
        }

        // Parameterized Constructor (partial data)
        public Student(string name, string course)
        {
            this.name = name;
            this.course = course;
            subject = null;
            university = null;
            email = null;
            phone = null;
        }

        // Full Constructor
        public Student(string name, string course, string subject, string university, string email, string phone)
        {
            this.name = name;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.email = email;
            this.phone = phone;
        }

        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("University: " + university);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone: " + phone);
        }
    }
