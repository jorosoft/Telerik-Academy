namespace InheritanceAndPolymorphism.Models
{
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string name)
            : base(name)
        {
            this.TeacherName = null;
            this.Students = new List<string>();
            this.Town = null;
        }        

        public OffsiteCourse(string name, string teacherName)
            : base(name)
        {
            this.TeacherName = teacherName;
            this.Students = new List<string>();
            this.Town = null;
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : base(name)
        {
            this.TeacherName = teacherName;
            this.Students = students;
            this.Town = null;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            var result = base.ToString();
            if (this.Town != null)
            {
                result += "; Town = ";
                result += this.Town;
            }

            result += " }";

            return result;
        }
    }
}
