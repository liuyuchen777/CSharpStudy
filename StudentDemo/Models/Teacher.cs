using System;
using System.ComponentModel.DataAnnotations;

namespace StudentDemo.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
