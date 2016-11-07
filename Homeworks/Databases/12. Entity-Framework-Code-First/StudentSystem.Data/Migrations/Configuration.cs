namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
            this.ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystem.Data.StudentSystemContext context)
        {
            context.Students.AddOrUpdate(
                s => s.Number,
                new Student()
                {
                    Name = "Pencho Ivanov",
                    Number = "12345"
                },
                new Student()
                {
                    Name = "Stanka Vylkova",
                    Number = "00001"
                },
                new Student()
                {
                    Name = "Kiro Skalata",
                    Number = "13131"
                },
                new Student()
                {
                    Name = "Mara Podrobnata",
                    Number = "55555"
                },
                new Student()
                {
                    Name = "Stamat Stamatov",
                    Number = "11111"
                });

            context.Courses.AddOrUpdate(
                c => c.Name,
                new Course()
                {
                    Name = "CSharp Fundamentals",
                    Description = "Not now..."
                },
                new Course()
                {
                    Name = "High Quality Code",
                    Description = "Not available!"
                },
                new Course()
                {
                    Name = "DSA",
                    Description = "In future maybe..."
                });
        }
    }
}
