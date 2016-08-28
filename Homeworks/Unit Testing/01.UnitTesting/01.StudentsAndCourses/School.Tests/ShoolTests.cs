namespace School.Tests
{
    using System;
    using StudentsAndCourses;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ShoolTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddStudent_GivenEmptyName_ShouldThrows()
        {
            var student = new Student(10001, "");
            var course = new Course("Mathematics");

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddStudent_GivenIdNotInRange_ShouldThrows()
        {
            var student = new Student(1, "Neno Nenov");
            var course = new Course("Physics");

            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudent_TryAddMoreThan30InCourse_ShouldThrows()
        {
            var course = new Course("Trigonometry");
            for (int i = 10000; i < 10050; i++)
            {
                var student = new Student(i, "Student " + i);

                course.AddStudent(student);
            }
        }

        [TestMethod]
        public void AddStudent_CorrectData_ShouldAddStudent()
        {
            var student = new Student(10010, "Kiro Kirov");
            var course = new Course("Algebra");

            course.AddStudent(student);

            Assert.AreEqual<int>(1, course.StudentsCount);
        }

        [TestMethod]
        public void RemoveStudent_CorrectData_ShouldRemoveStudent()
        {
            var student = new Student(11111, "Pesho Petrov");
            var course = new Course("C# OOP");

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual<int>(0, course.StudentsCount);
        }

        [TestMethod]
        public void ChangeStudentName_CorrectData_ShouldChangeName()
        {
            var student = new Student(10110, "Sasho Todorov");
            var newName = "Doncho Donev";

            student.Name = newName;

            Assert.AreEqual<string>(newName, student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ChangeStudentId_PassedNegativeId_ShouldThrows()
        {
            var student = new Student(10001, "Tosho Botev");
            var newId = -5;

            student.ID = newId;
        }

        [TestMethod]
        public void ChangeCourseName_CorrectData_ShouldChangeName()
        {
            var course = new Course("JS UI");
            var newName = "JS UI & DOM";

            course.Name = newName;

            Assert.AreEqual<string>(newName, course.Name);
        }

        [TestMethod]
        public void GetStudentId_ReadValue_ShouldGetCorrectId()
        {
            var id = 15000;
            var student = new Student(id, "Gaco Bacov");

            Assert.AreEqual<int>(id, student.ID);
        }
    }
}
