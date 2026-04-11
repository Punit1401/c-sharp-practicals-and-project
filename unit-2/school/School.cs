// Question:
// We have a school system:
// - School has Classes and Students
// - Each Class has Teachers
// - Each Teacher teaches multiple Disciplines
// - Student has Name and Roll Number
// - Class has unique ID
// - Discipline has Name, Lessons, Exercises
// Also:
// - Define fields, properties, constructors, methods
// - Use abstract class and abstract methods

using System;
using System.Collections.Generic;

namespace lab_work_1
{
    abstract class School
    {
        public abstract void Display();
    }

    class Discipline
    {
        public string Name { get; set; }
        public int Lessons { get; set; }
        public int Exercises { get; set; }

        public Discipline(string name, int lessons, int exercises)
        {
            Name = name;
            Lessons = lessons;
            Exercises = exercises;
        }

        public void Show()
        {
            Console.WriteLine($"Discipline: {Name}, Lessons: {Lessons}, Exercises: {Exercises}");
        }
    }

    // ---------------- Teacher Class ----------------
    class Teacher : School
    {
        public string Name { get; set; }
        public List<Discipline> Disciplines { get; set; }

        public Teacher(string name)
        {
            Name = name;
            Disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline d)
        {
            Disciplines.Add(d);
        }

        public override void Display()
        {
            Console.WriteLine("\nTeacher: " + Name);
            foreach (var d in Disciplines)
            {
                d.Show();
            }
        }
    }

    class Student : School
    {
        public string Name { get; set; }
        public int RollNo { get; set; }

        public Student(string name, int roll)
        {
            Name = name;
            RollNo = roll;
        }

        public override void Display()
        {
            Console.WriteLine($"Student: {Name}, Roll No: {RollNo}");
        }
    }

    class SchoolClass : School
    {
        public string ClassID { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public SchoolClass(string id)
        {
            ClassID = id;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            Teachers.Add(t);
        }

        public override void Display()
        {
            Console.WriteLine("\nClass ID: " + ClassID);

            Console.WriteLine("\n--- Students ---");
            foreach (var s in Students)
            {
                s.Display();
            }

            Console.WriteLine("\n--- Teachers ---");
            foreach (var t in Teachers)
            {
                t.Display();
            }
        }
    }
}
