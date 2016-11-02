using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<StudentsInCourses> studentsInCourses;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.studentsInCourses = new HashSet<StudentsInCourses>();
            this.homeworks = new HashSet<Homework>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string Materials { get; set; }

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
