namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, IComment
    {
        private string comment;

        public Teacher(string firstName, string lastName, List<Discipline> disciplines, string comment = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Disciplines = disciplines;
            this.Comment = comment;
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

        public List<Discipline> Disciplines { get; set; }
    }
}
