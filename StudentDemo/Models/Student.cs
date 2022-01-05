using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDemo.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Hobby { get; set; }
        public bool GirlFriend { get; set; }

        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
