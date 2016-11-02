using System;
using System.Linq;
using StudentSystem.Data;

namespace StudentSystem.ConsoleClient
{
    internal class StudentSystem
    {
        internal static void Main()
        {
            using (StudentSystemContext db = new StudentSystemContext())
            {
                var students = db.Students.ToList();
                var courses = db.Courses.ToList();

                Console.WriteLine("Students in system:");
                Console.WriteLine("=======================");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Name} - {student.Number}");
                }

                Console.WriteLine();
                Console.WriteLine("Courses in system:");
                Console.WriteLine("=======================");
                foreach (var course in courses)
                {
                    Console.WriteLine(course.Name);
                }

                Console.WriteLine();
            }
        }
    }
}
