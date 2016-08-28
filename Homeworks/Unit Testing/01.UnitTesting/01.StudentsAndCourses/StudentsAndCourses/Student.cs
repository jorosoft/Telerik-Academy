namespace StudentsAndCourses
{
    
    public class Student
    {
        private string name;
        private int id;

        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
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

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                Validator.ValidateIdInRange(value, "ID must be between 10000 and 99999!");

                this.id = value;
            }
        }
    }
}
