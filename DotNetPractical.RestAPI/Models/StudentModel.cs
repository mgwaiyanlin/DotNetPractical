using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetPractical.RestAPI.Models
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
