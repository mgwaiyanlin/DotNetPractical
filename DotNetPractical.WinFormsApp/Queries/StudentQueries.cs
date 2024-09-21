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
        public static string ViewOneStudent { get; } = @"SELECT * FROM students WHERE id = @id";

        public static string CreateStudent { get; } = @"INSERT INTO [dbo].[Students]
               ([student_name]
               ,[student_age]
               ,[student_year]
               ,[join_date]
               ,[major])
         VALUES
               (@student_name, @student_age, @student_year, @join_date, @major)";

        public static string DeleteStudent { get; } = @"DELETE FROM [dbo].[Students] WHERE id = @id";
        public static string UpdateStudent { get; } = @"UPDATE [dbo].[Students]
               SET [student_name] = @student_name,
                  [student_age] = @student_age,
                  [student_year] = @student_year,
                  [join_date] = @join_date,
                  [major] = @major
             WHERE id = @id";
    }
}
