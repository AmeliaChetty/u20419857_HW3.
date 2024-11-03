using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u20419857_HW3.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string SName { get; set; }

        [Required]
        [StringLength(50)]
        public string SSurname { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [StringLength(10)]
        public string Class { get; set; }

        [Range(0, 100)]
        public int Point { get; set; }

        public ICollection<Borrow> Borrows { get; set; }
    }
}