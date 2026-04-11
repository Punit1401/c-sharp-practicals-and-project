using System;

namespace lab_work_1
{
  class Program
    {
        static void Main()
        {
            // Create disciplines
            Discipline d1 = new Discipline("Math", 30, 20);
            Discipline d2 = new Discipline("Science", 25, 15);

            // Create teacher
            Teacher t1 = new Teacher("Mr. Sharma");
            t1.AddDiscipline(d1);
            t1.AddDiscipline(d2);

            // Create students
            Student s1 = new Student("Punit", 1);
            Student s2 = new Student("Rahul", 2);

            // Create class
            SchoolClass c1 = new SchoolClass("MCA-1");

            c1.AddStudent(s1);
            c1.AddStudent(s2);
            c1.AddTeacher(t1);

            // Display full details
            c1.Display();

            Console.ReadLine();
        }
    }
