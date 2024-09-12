using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetPractical.RestAPI.Models
{
    [Table("students")]
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public int StudentAge { get; set; }
        public int StudentYear { get; set; }
        public string? JoinDate { get; set; }
        public string? Major { get; set; }

    }
}
