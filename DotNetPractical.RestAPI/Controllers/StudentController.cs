using DotNetPractical.RestAPI.Models;
using DotNetPractical.RestAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPractical.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DapperService _dapperService = new DapperService(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);

        [HttpGet("get_all_students")]
        public IActionResult GetStudents()
        {
            string query = "SELECT * FROM students";
            var students = _dapperService.Query<StudentModel>(query);
            return Ok(students);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = FindById(id);

            if (student == null)
            {
                return NotFound("The data is not found!");
            }

            return Ok(student);
        }

        [HttpPost("add_new_students")]
        public IActionResult CreateNewStudent(StudentModel studentModel)
        {
            string query = @"INSERT INTO [dbo].[Students]
               ([student_name]
               ,[student_age]
               ,[student_year]
               ,[join_date]
               ,[major])
         VALUES
               (@student_name, @student_age, @student_year, @join_date, @major)";

            var result = _dapperService.Execute(query, studentModel);

            string message = result > 0 ? "Data created successfully." : "Failed to create data.";
            return Ok(message);
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateStudent(int id, StudentModel studentModel)
        {
            var student = FindById(id);
            if (student == null)
            {
                return NotFound("The data is not found!");
            }

            studentModel.id = id;

            string query = @"UPDATE [dbo].[Students]
               SET [student_name] = @student_name,
                  [student_age] = @student_age,
                  [student_year] = @student_year,
                  [join_date] = @join_date,
                  [major] = @major
             WHERE id = @id";

            int result = _dapperService.Execute(query, studentModel);

            string message = result > 0 ? "Data updated successfully." : "Failed to update data.";
            return Ok(message);
        }

        [HttpPatch("patch/{id}")]
        public IActionResult PatchStudent(int id, StudentModel studentModel)
        {
            var search_student = FindById(id);
            if (search_student == null)
            {
                return NotFound("The data is not found!");
            }

            string conditions = string.Empty;

            if(!string.IsNullOrEmpty(studentModel.student_name))
            {
                conditions += "[student_name] = @student_name, ";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(studentModel.student_age)))
            {
                conditions += "[student_age] = @student_age, ";
            }

            if (!string.IsNullOrEmpty(Convert.ToString(studentModel.student_year)))
            {
                conditions += "[student_year] = @student_year, ";
            }

            if (!string.IsNullOrEmpty(studentModel.join_date))
            {
                conditions += "[join_date] = @join_date, ";
            }

            if (!string.IsNullOrEmpty(studentModel.major))
            {
                conditions += "[major] = @major, ";
            }

            conditions = conditions.Substring(0, conditions.Length - 2);

            studentModel.id = id;

            string query = $@"UPDATE [dbo].[Students]
               SET {conditions}
             WHERE id = @id";

            int result = _dapperService.Execute(query, studentModel);

            string message = result > 0 ? "Data patched successfully." : "Failed to patch data.";
            return Ok(message);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = FindById(id);
            if(student == null)
            {
                return NotFound("The data is not found!");
            }

            string query = @"DELETE FROM [dbo].[Students] WHERE id = @id";

            int result = _dapperService.Execute(query, student);
            string message = result > 0 ? "Data deleted successfully." : "Failed to delete data.";
            return Ok(message);
        }

        private StudentModel FindById(int id)
        {
            string query = "SELECT * FROM students WHERE id = @id";

            var student = _dapperService.QueryFirstOrDefault<StudentModel>(query, new StudentModel { id = id });

            return student;
        }
    }
}
