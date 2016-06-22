namespace _9_19.StudentsSystem
{
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }
    }
}
