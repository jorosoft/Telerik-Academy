namespace _01.SchoolClasses
{
    using System.Collections.Generic;

    internal class SchoolClasses
    {
        internal static void Main()
        {
            //// Test School
            var school = new List<SchoolClass>();
            var math = new SchoolClass("Mathematics");
            math.ClassStudents.Add(new Student("Ivan", "Ivanov", 42));
            math.ClassStudents.Add(new Student("Petyr", "Nikolov", 7, "bai Pesho"));
            math.ClassStudents.Add(new Student("Stanka", "Beztankova", 18));
            math.ClassTeachers.Add(new Teacher("Todor", "Todorov", new List<Discipline>() 
            {
             new Discipline("Algebra", 120, 60),
             new Discipline("Geometry", 100, 45),
             new Discipline("Trigonometry", 88, 40, "must have exam preparation")
            }));
            school.Add(math);
            var physics = new SchoolClass("Physics");
            math.ClassStudents.Add(new Student("Stamat", "Kirilov", 13));
            math.ClassStudents.Add(new Student("Ginka", "Dobreva", 15, "lelq Ginche"));
            math.ClassStudents.Add(new Student("Dobri", "Dobrunov", 22));
            math.ClassTeachers.Add(new Teacher("Venci", "Micov", new List<Discipline>()
            {
             new Discipline("Molecular physics", 120, 60),
             new Discipline("Optical Physics", 100, 45),
             new Discipline("Asrtonomy", 88, 40, "must have exam preparation")
            }));
            school.Add(physics);
        }        
    }
}
