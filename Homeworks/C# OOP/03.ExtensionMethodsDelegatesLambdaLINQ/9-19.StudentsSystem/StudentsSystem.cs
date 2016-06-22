namespace _9_19.StudentsSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class StudentsSystem
    {
        internal static void Main()
        {
            var students = new List<Student>
            {
                new Student
                {
                    FirstName = "Ivan",
                    LastName = "Petrov",
                    FN = "123456",
                    Tel = "0287654321",
                    Email = "ala@bala.com",
                    Marks = new List<int> { 2, 3, 5, 4, 4, 5 },
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Petyr",
                    LastName = "Marinov",
                    FN = "111106",
                    Tel = "0981111111",
                    Email = "ali@baba.net",
                    Marks = new List<int> { 6, 2, 6, 5, 5, 5 },
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Maria",
                    LastName = "Todorova",
                    FN = "232323",
                    Tel = "0982121212",
                    Email = "mara@bara.bg",
                    Marks = new List<int> { 6, 3, 6, 5, 4, 5 },
                    GroupNumber = 1
                },
                new Student
                {
                    FirstName = "Tosho",
                    LastName = "Stamatov",
                    FN = "666666",
                    Tel = "0989999999",
                    Email = "toto@kutunio.it",
                    Marks = new List<int> { 2, 3, 2, 2, 3, 2 },
                    GroupNumber = 7
                },
                new Student
                {
                    FirstName = "Penka",
                    LastName = "Gruiova",
                    FN = "123106",
                    Tel = "0989878777",
                    Email = "pepa@lepa.org",
                    Marks = new List<int> { 5, 4, 5, 4, 3, 2 },
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Todor",
                    LastName = "Todorov",
                    FN = "333333",
                    Tel = "0982121212",
                    Email = "toci@abv.bg",
                    Marks = new List<int> { 5, 6, 5, 6, 4, 4 },
                    GroupNumber = 2
                },
                new Student
                {
                    FirstName = "Sashka",
                    LastName = "Mihaylova",
                    FN = "787878",
                    Tel = "0289554433",
                    Email = "sashka@abv.bg",
                    Marks = new List<int> { 5, 3, 2, 4, 4, 2 },
                    GroupNumber = 5
                }
            };
            Console.WriteLine("======== ALL STUDENTS ========");
            PrintStudents(students);
            Console.WriteLine();
            Console.WriteLine("===== STUDENTS IN GROUP 2 =====");
            PrintStudents(GetStudentsOfGroup(students, 2));
            Console.WriteLine();
            Console.WriteLine("== STUDENTS IN GROUP 2 BY EXT METHODS ==");
            PrintStudents(GetStudentsOfGroupByExtMethods(students, 2));
            Console.WriteLine();
            Console.WriteLine("==== STUDENTS WITH E-MAIL IN ABV.BG ====");
            PrintStudents(GetStudentsByEmailDomain(students, "abv.bg"));
            Console.WriteLine();
            Console.WriteLine("==== STUDENTS WITH PHONE INE SOFIA ====");
            PrintStudents(GetStudentsByPhoneArea(students, "02"));
            Console.WriteLine();
            Console.WriteLine("======== STUDENTS WITH MARK 6 ========");
            PrintStudentsWithMarkExcellent(students);
            Console.WriteLine("======== STUDENTS WITH TWO MARK 2 ========");
            PrintStudentsWithTwoMarksPoor(students);
            Console.WriteLine("======= STUDENTS ENROLLED IN 2006 =======");
            PrintExtractedMarksFor06(students);
            //// Create department Mathematics
            var departments = new List<Group>()
            {
                new Group { GroupNumber = 1, DepartmentName = "Mathematics" },
                new Group { GroupNumber = 2, DepartmentName = "Physics" },
                new Group { GroupNumber = 5, DepartmentName = "Biologics" },
                new Group { GroupNumber = 7, DepartmentName = "Sports" }
            };
            Console.WriteLine("==== STUDENTS IN MATHEMATICS DEPARTMENT ====");
            PrintStudents(ExtractStudentsInMathematics(students, departments));
            Console.WriteLine();
            Console.WriteLine("==== STUDENTS IN GROUPS BY GROUP NUMBER ====");
            PrintGroupedStudentsByGroupNumber(students);
            Console.WriteLine();
            Console.WriteLine("==== STUDENTS IN GROUPS BY GROUP NAME WITH EXT. METHODS ====");
            PrintGroupedStudentsByGroupNameExtMethods(students);
            Console.WriteLine();
        }

        private static void PrintStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.FN}");
            }
        }

        private static List<Student> GetStudentsOfGroup(List<Student> students, int groupNumber)
        {
            var result =
                from s in students
                where s.GroupNumber == groupNumber
                orderby s.FirstName
                select s;
            return result.ToList();
        }

        private static List<Student> GetStudentsOfGroupByExtMethods(List<Student> students, int groupNumber)
        {
            var result = students
                .Where(s => s.GroupNumber == groupNumber)
                .OrderBy(s => s.FirstName)
                .ToList();
            return result;
        }

        private static List<Student> GetStudentsByEmailDomain(List<Student> students, string domain)
        {
            var result =
                from s in students
                where s.Email.Contains(domain)
                select s;
            return result.ToList();
        }

        private static List<Student> GetStudentsByPhoneArea(List<Student> students, string area)
        {
            var result =
                from s in students
                where s.Tel.StartsWith(area)
                select s;
            return result.ToList();
        }

        private static void PrintStudentsWithMarkExcellent(List<Student> students)
        {
            var studentsWithMarkExcellent =
                from s in students
                where s.Marks.Contains(6)
                select new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    Marks = s.Marks
                };
            foreach (var student in studentsWithMarkExcellent)
            {
                Console.Write($"{student.FullName} - ");
                foreach (var mark in student.Marks)
                {
                    Console.Write($"{mark} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void PrintStudentsWithTwoMarksPoor(List<Student> students)
        {
            var studentsWithTwoMarkPoor = students
                .Where(s => s.Marks.Where(m => m == 2).Count() == 2)
                .Select(s => new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    Marks = s.Marks
                });
            foreach (var student in studentsWithTwoMarkPoor)
            {
                Console.Write($"{student.FullName} - ");
                foreach (var mark in student.Marks)
                {
                    Console.Write($"{mark} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void PrintExtractedMarksFor06(List<Student> students)
        {
            var studentsFrom2006 = students
                .Where(s => s.FN[4] == '0' && s.FN[5] == '6')
                .ToList()
                .Select(s => new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    Marks = s.Marks,
                    FN = s.FN
                });
            foreach (var student in studentsFrom2006)
            {
                Console.Write($"{student.FullName} - {student.FN} -> ");
                foreach (var mark in student.Marks)
                {
                    Console.Write($"{mark} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static List<Student> ExtractStudentsInMathematics(List<Student> students, List<Group> departments)
        {
            var mathematics =
                from s in students
                join d in departments on s.GroupNumber equals d.GroupNumber
                select s;
            return mathematics.ToList();
        }

        private static void PrintGroupedStudentsByGroupNumber(List<Student> students)
        {
            var groupedStudents =
                from s in students
                group s by s.GroupNumber into g
                orderby g.Key
                select g;
            foreach (var group in groupedStudents)
            {
                Console.WriteLine("------ Group {0} ------", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} - {student.FN}");
                }

                Console.WriteLine();
            }
        }

        private static void PrintGroupedStudentsByGroupNameExtMethods(List<Student> students)
        {
            var groupedStudents = students
                .GroupBy(s => s.GroupNumber)
                .OrderBy(g => g.Key);
                
            foreach (var group in groupedStudents)
            {
                Console.WriteLine("------ Group {0} ------", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} - {student.FN}");
                }

                Console.WriteLine();
            }
        }
    }
}
