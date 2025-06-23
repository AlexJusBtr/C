using System;
using System.Collections.Generic;

namespace Student_Course_Enrollment_System
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }

        public Student(string id, string name)
        {
            StudentId = id;
            Name = name;
        }
    }
    public class Course
    {
        public string CourseName { get; set; }
        private LinkedList<Student> enrolledStudents = new LinkedList<Student>();

        public Course(string courseName)
        {
            CourseName = courseName;
        }
        public void AddStudent(Student student)
        {
            enrolledStudents.AddLast(student);
        }
        public void RemoveStudent(string studentId)
        {
            var node = enrolledStudents.First;
            while (node != null)
            {
                if (node.Value.StudentId == studentId)
                {
                    enrolledStudents.Remove(node);
                    return;
                }
                node = node.Next;
            }
            Console.WriteLine($"Student with ID {studentId} not found in {CourseName}.");
        }
        public void DisplayStudents()
        {
            Console.WriteLine("\nEnrolled Students: ");
            foreach (var student in enrolledStudents)
            {
                Console.WriteLine($"Name: {student.Name}, ID: {student.StudentId}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("Some Course I Dont Know");

            course.AddStudent(new Student("ST101", "Alice Smith"));
            course.AddStudent(new Student("ST102", "Brian Johnson"));
            course.AddStudent(new Student("ST103", "Carla James"));
            course.AddStudent(new Student("ST104", "David Lee"));

            course.DisplayStudents();

            course.RemoveStudent("ST102");

            course.DisplayStudents();

            Console.ReadKey();
        }
    }
}
