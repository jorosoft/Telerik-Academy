namespace _01.SchoolClasses
{
    using System;

    public class Student : Person, IComment
    {
        private int classNumber;
        private string comment;

        public Student(string firstName, string lastName, int classNumber, string comment = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ClassNumber = classNumber;
            this.Comment = comment;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Class number can't be smaller than 1!");
                }

                this.classNumber = value;
            }
        }

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
    }
}
