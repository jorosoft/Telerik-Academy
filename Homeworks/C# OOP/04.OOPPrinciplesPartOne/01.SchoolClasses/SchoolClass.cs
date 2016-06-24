namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass : IComment
    {
        private string comment;
        private string textID;

        public SchoolClass(string textID, string comment = null)
        {
            this.TextID = textID;
            this.Comment = comment;
        }

        public List<Student> ClassStudents { get; set; } = new List<Student>();

        public List<Teacher> ClassTeachers { get; set; } = new List<Teacher>();

        public string Comment
        {
            get
            {
                if (this.comment == null)
                {
                    return string.Empty;
                }

                return this.comment;
            }

            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Comment length can't be smaller than 1 symbol!");
                }

                this.comment = value.Trim();
            }
        }

        public string TextID
        {
            get
            {
                return this.textID;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Class identifier name can't be smaller than 1 symbol!");
                }

                this.textID = value.Trim();
            }
        }       
    }
}
