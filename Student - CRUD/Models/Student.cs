using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student___CRUD.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Student ID")]
        public string StudentID { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Student Last Name")]
        public string StudentLastName { get; set; }

        [Display(Name = "Student Email")]
        public string Email { get; set; }

        [Display(Name = "Student Password")]
        public string Password { get; set; }


    }
}
