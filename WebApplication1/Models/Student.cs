using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{

    public class Student
    {
        [HiddenInput(DisplayValue = false)]
        public int StudentID { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int Class { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
            ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Fees paid")]
        public bool HasPaid { get; set; }
    }
}