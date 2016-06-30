namespace _01_03.StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private string course;

        public Student(string firstName, string middleName, string lastName, int ssn, string address, 
                        string phoneNumber, string email, string course, 
                        Specialty speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Name length can't be smaller than 1 symbol!");
                }

                this.firstName = value.Trim();
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Name length can't be smaller than 1 symbol!");
                }

                this.middleName = value.Trim();
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Name length can't be smaller than 1 symbol!");
                }

                this.lastName = value.Trim();
            }
        }

        public int SSN
        {
            get
            {
                return this.ssn;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("SSN number can't be negative or zero!");
                }

                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Address length can't be smaller than 1 symbol!");
                }

                this.address = value.Trim();
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Phone length can't be smaller than 1 symbol!");
                }

                this.phoneNumber = value.Trim();
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Email length can't be smaller than 1 symbol!");
                }

                this.email = value.Trim();
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Course length can't be smaller than 1 symbol!");
                }

                this.course = value.Trim();
            }
        }

        public Specialty Speciality { get; set; }

        public University University { get; set; }

        public Faculty Faculty { get; set; }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            bool expression =
                firstStudent.FirstName == secondStudent.FirstName
                && firstStudent.MiddleName == secondStudent.MiddleName
                && firstStudent.LastName == secondStudent.LastName
                && firstStudent.SSN == secondStudent.SSN
                && firstStudent.Address == secondStudent.Address
                && firstStudent.PhoneNumber == secondStudent.PhoneNumber
                && firstStudent.Email == secondStudent.Email
                && firstStudent.Course == secondStudent.Course
                && firstStudent.Speciality == secondStudent.Speciality
                && firstStudent.University == secondStudent.University
                && firstStudent.Faculty == secondStudent.Faculty;
            if (expression)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            if (firstStudent == secondStudent)
            {
                return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            if (this == obj as Student)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * this.SSN.GetHashCode() + this.MiddleName.Length;
            hash = hash * base.GetHashCode() >> ((int)this.Speciality + 11);
            return hash;
        }

        public override string ToString()
        {
            var pattern = new StringBuilder();
            pattern.AppendLine("-------------------------------------------");
            pattern.AppendLine($"Student:  {this.FirstName} {this.MiddleName} {this.LastName}");
            pattern.AppendLine($"SSN:      {this.SSN}");
            pattern.AppendLine($"Address:  {this.Address}");
            pattern.AppendLine($"Phone:    {this.PhoneNumber}");
            pattern.AppendLine($"E-mail:   {this.Email}");
            pattern.AppendLine($"Course:   {this.Course}");
            pattern.AppendLine($"Study in: {this.University}, {this.Faculty}, {this.Speciality}");
            pattern.AppendLine("-------------------------------------------");
            return pattern.ToString();
        }

        public object Clone()
        {
            var newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, 
                this.PhoneNumber, this.Email, this.Course, this.Speciality, this.University, this.Faculty);
            return newStudent;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SSN.CompareTo(other.SSN) != 0)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }      
    }
}
