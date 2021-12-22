using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDemo.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }  // primary key
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual List<Enrollment> Enrollments { get; set; }
    }
}
