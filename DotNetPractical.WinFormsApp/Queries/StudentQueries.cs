using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractical.WinFormsApp.Queries
{
    public class StudentQueries
    {
        public static string ViewAllStudents { get; } = @"SELECT * FROM students";

        public static string CreateStudent { get; } = @"INSERT INTO [dbo].[Students]
               ([student_name]
               ,[student_age]
               ,[student_year]
               ,[join_date]
               ,[major])
         VALUES
               (@student_name, @student_age, @student_year, @join_date, @major)";

    }
}
