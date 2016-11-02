using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Student
    {
        private ICollection<StudentsInCourses> studentsInCourses;
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.studentsInCourses = new HashSet<StudentsInCourses>();
            this.homeworks = new HashSet<Homework>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        [Index(IsUnique = true)]
        public string Number { get; set; }

        public virtual ICollection<StudentsInCourses> StudentsInCourses
        {
            get { return this.studentsInCourses; }
            set { this.studentsInCourses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}