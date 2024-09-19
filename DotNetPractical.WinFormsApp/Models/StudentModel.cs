﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractical.WinFormsApp.Models
{
    [Table("students")]
    public class StudentModel
    {
        [Key]
        public int id { get; set; }
        public string? student_name { get; set; }
        public int student_age { get; set; }
        public int student_year { get; set; }
        public string? join_date { get; set; }
        public string? major { get; set; }

    }
}
