namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class StudentsAndWorkers
    {
        internal static void Main()
        {
            var students = new Student[] 
            {
                new Student("Pesho", "Petrov", 4),
                new Student("Ivan", "Stoyanov", 6),
                new Student("Maria", "Ivanova", 2),
                new Student("Kiro", "Rashev", 5),
                new Student("Kichka", "Todorova", 3),
                new Student("Viktoria", "Petrova", 2),
                new Student("Snajana", "Atanasova", 6),
                new Student("Valyo", "Nikolov", 5),
                new Student("Cvetan", "Cvetanov", 5),
                new Student("Mihaela", "Kostova", 4)
            };
            var workers = new Worker[] 
            {
                new Worker("Lalo", "Lalov", 120.55m, 8),
                new Worker("Dimo", "Kirov", 100.00m, 7),
                new Worker("Boyko", "Borisov", 800.50m, 2),
                new Worker("Delqn", "Peevski", 1000.00m, 4),
                new Worker("Kuno", "Totev", 400.00m, 6),
                new Worker("Bistra", "Konova", 500.90m, 8),
                new Worker("Denko", "Tupov", 330.22m, 8),
                new Worker("Stanka", "Beteerova", 420.00m, 10),
                new Worker("Andrey", "Vylev", 360.00m, 12),
                new Worker("Sashka", "Vaseva", 385.75m, 9)
            };

            Console.WriteLine("======================= ORIGINAL LIST OF STUDENTS =======================");
            PrintStudents(students);
            Console.WriteLine();
            Console.WriteLine("==================== SORTED LIST OF STUDENTS BY GRADE ====================");
            PrintStudents(GetSortedStudentsByGrade(students));
            Console.WriteLine();
            Console.WriteLine("======================= ORIGINAL LIST OF WORKERS =======================");
            PrintWorkers(workers);
            Console.WriteLine();
            Console.WriteLine("================ SORTED LIST OF WORKERS BY MONEY PER HOUR ================");
            PrintWorkers(GetSortedWorkersByMoneyPerHour(workers));
            Console.WriteLine();
            var humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);
            Console.WriteLine("=============== SORTED LIST OF HUMANS BY FIRS AND LAST NAME ===============");
            PrintMergedLists(humans);
            Console.WriteLine();
        }

        internal static void PrintStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Grade}");
            }
        }

        internal static Student[] GetSortedStudentsByGrade(Student[] students)
        {
            var query = students.OrderBy(s => s.Grade);
            return query.ToArray();
        }

        internal static void PrintWorkers(Worker[] workers)
        {
            foreach (var worker in workers)
            {               
                Console.WriteLine($"{worker.FirstName} {worker.LastName} - {worker.MoneyPerHour()} lv. per hour");
            }
        }

        internal static Worker[] GetSortedWorkersByMoneyPerHour(Worker[] workers)
        {
            var query = workers.OrderByDescending(s => s.MoneyPerHour());
            return query.ToArray();
        }

        internal static void PrintMergedLists(List<Human> humans)
        {
            var queryResult = humans
                .OrderBy(h => h.FirstName)
                .ThenBy(h => h.LastName);
            foreach (var human in queryResult)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            } 
        }
    }
}
