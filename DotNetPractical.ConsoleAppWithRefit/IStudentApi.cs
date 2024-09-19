using Refit;

namespace DotNetPractical.ConsoleAppWithRefit;

public interface IStudentApi
{
    [Get("/api/student/get_all_students")]
    Task<List<StudentModel>> GetStudents();

    [Get("/api/student/get_a_student/{id}")]
    Task<StudentModel> GetOneStudent(int id);

    [Post("/api/student/add_new_students")]
    Task<string> CreateStudent(StudentModel student);

    [Put("/api/student/update/{id}")]
    Task<string> UpdateStudent(int id, StudentModel student);
    
    [Delete("/api/student/delete/{id}")]
    Task<string> DeleteStudent(int id);
}

public class StudentModel
{
    public int id { get; set; }
    public string? student_name { get; set; }
    public int student_age { get; set; }
    public int student_year { get; set; }
    public string? join_date { get; set; }
    public string? major { get; set; }
}