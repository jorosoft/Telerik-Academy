namespace InheritanceAndPolymorphism.Models
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {      
        public LocalCourse(string name)
            : base(name)
        {
            this.TeacherName = null;
            this.Students = new List<string>();
            this.Lab = null;
        }

        public LocalCourse(string name, string teacherName)
            : base(name)
        {
            this.TeacherName = teacherName;
            this.Students = new List<string>();
            this.Lab = null;
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
            : base(name)
        {
            this.TeacherName = teacherName;
            this.Students = students;
            this.Lab = null;
        }

        public string Lab { get; set; }        

        public override string ToString()
        {
            var result = base.ToString();
            if (this.Lab != null)
            {
                result += "; Lab = ";
                result += this.Lab;
            }

            result += " }";

            return result;
        }
    }
}
