using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class StudentsInCourses
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }
        
        public virtual Student Student { get; set; }

        [Required]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
