namespace StudentsAndCourses
{
    using System.Collections.Generic;
    public class Course
    {
        private string name;
        private IList<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.ValidateStringIsNullOrEmpty(value, "Name can't be null or empty!");

                this.name = value.Trim();
            }
        }

        public int StudentsCount
        {
            get
            {
                return this.students.Count;
            }
        }

        public void AddStudent(Student student)
        {
            Validator.ValidateStudentsCountInCourse((byte)students.Count, "Students in a course should be less than 30!");

            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

    }
}
