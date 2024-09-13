using System;

namespace DotNetPractical.ConsoleAppWithHttpClient
{
    internal class StudentDto
    {
        public int id { get; set; }
        public string? student_name { get; set; }
        public int student_age { get; set; }
        public int student_year { get; set; }
        public string? join_date { get; set; }
        public string? major { get; set; }
    }
}
