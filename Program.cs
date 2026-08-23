using System;

namespace StudentAdmissionManagement
{
    // Student Class
    class Student
    {
        // Private data members
        private int studentId;
        private string studentName;
        private int age;
        private string course;

        // Constructor
        public Student(int id, string name, int studentAge, string studentCourse)
        {
            studentId = id;
            studentName = name;
            age = studentAge;
            course = studentCourse;
        }

        // Display student details
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n----- Student Admission Details -----");
            Console.WriteLine("Student ID   : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Age          : " + age);
            Console.WriteLine("Course       : " + course);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Student Admission Management =====");

            // Take input from user
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            // Create object using user input
            Student student = new Student(id, name, age, course);

            // Display details
            student.DisplayStudentDetails();

            Console.WriteLine("\nAdmission Successful!");

            Console.ReadLine();
        }
    }
}