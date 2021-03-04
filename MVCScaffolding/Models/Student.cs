﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCScaffolding.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

    }
}