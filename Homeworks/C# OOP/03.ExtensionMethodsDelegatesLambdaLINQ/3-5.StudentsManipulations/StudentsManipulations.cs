namespace _3_5.StudentsManipulations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class StudentsManipulations
    {
        internal static void Main()
        {
            var students = new List<Student>()
            {
                new Student() { FirstName = "Pesho", LastName = "Petrov", Age = 21 },
                new Student() { FirstName = "Ivan", LastName = "Ivanov", Age = 35 },
                new Student() { FirstName = "Petya", LastName = "Ivanova", Age = 23 },
                 new Student() { FirstName = "Ivan", LastName = "Petrov", Age = 39 },
                new Student() { FirstName = "Mariq", LastName = "Petrova", Age = 17 },
                new Student() { FirstName = "Stamat", LastName = "Kirov", Age = 27 },
                new Student() { FirstName = "Stanka", LastName = "Iordanova", Age = 20 }
            };
            Console.WriteLine("================= ORIGINAL STUDENTS LIST =================");
            PrintStudents(students);
            Console.WriteLine();
            Console.WriteLine("===== STUDENTS WHOSE FIRST NAME IS BEFORE LAST NAME =====");
            PrintStudents(FirstBeforeLast(students));
            Console.WriteLine();
            Console.WriteLine("======= STUDENTS WITH AGE BETWEEN 18 AND 24 YEARS =======");
            foreach (var student in AgeRange(students))
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("=============== ORDERED LIST OF STUDENTS ===============");
            PrintStudents(OrderStudents(students));
            Console.WriteLine();
            Console.WriteLine("========== ORDERED LIST OF STUDENTS WITH LINQ===========");
            PrintStudents(OrderStudentsLinq(students));
            Console.WriteLine();
        }

        private static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Age} years old");
            }
        }

        private static List<Student> FirstBeforeLast(List<Student> students)
        {
            var result =
                from s in students
                where string.Compare(s.FirstName, s.LastName) < 0
                select s;

            return result.ToList();
        }

        private static List<string> AgeRange(List<Student> students)
        {
            var result =
                from s in students
                where s.Age >= 18 && s.Age <= 24
                select s.FirstName + " " + s.LastName;
            return result.ToList();
        }

        private static List<Student> OrderStudents(List<Student> students)
        {
            var result = students
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName)
                .ToList();
            return result;
        }

        private static List<Student> OrderStudentsLinq(List<Student> students)
        {
            var result =
                from s in students
                orderby s.FirstName descending,
                        s.LastName descending
                select s;
            return result.ToList();
        }        
    }
}
