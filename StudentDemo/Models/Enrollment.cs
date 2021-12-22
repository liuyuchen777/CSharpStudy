using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDemo.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; } // primary key
        public int ClassId { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student;
        [ForeignKey("ClassId")]
        public Class Class;
    }
}
