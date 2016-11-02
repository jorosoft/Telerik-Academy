using System;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TimeSent { get; set; }

        [Required]
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        [Required]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
