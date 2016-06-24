namespace _01.SchoolClasses
{
    using System;

    public class Discipline : IComment
    {
        private string comment;
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercizes = numberOfExercises;
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Discipline name length can't be smaller than 1 symbol!");
                }

                this.name = value.Trim();
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Number of lectures can't be smaller than 1!");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercizes
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Number of exercises can't be smaller than 1!");
                }

                this.numberOfExercises = value;
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
