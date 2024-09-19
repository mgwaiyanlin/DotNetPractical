using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractical.ConsoleAppWithRefit
{
    internal class RefitProgram
    {
        private readonly IStudentApi _studentApi = RestService.For<IStudentApi>("https://localhost:7122");

        public async Task RunAsync()
        {
            //await UpdateStudentAsync(1003, "Deadpool", 28, 2018, "January 2024", "Marvel Jessus");
            await DeleteAsync(1002);
        }

        private async Task ReadAllAsync()
        {
            var dataPack = await _studentApi.GetStudents();

            foreach (var data in dataPack)
            {
                Console.WriteLine($"Student id: {data.id}");
                Console.WriteLine($"Student Name: {data.student_name}");
                Console.WriteLine($"Student Age: {data.student_age}");
                Console.WriteLine($"Join Date: {data.join_date}");
                Console.WriteLine($"Student Year: {data.student_year}");
                Console.WriteLine($"Target Major: {data.major}");
                Console.WriteLine("###################################\n");
            }
        }

        private async Task ReadOneAsync()
        {
            try
            {
                var data = await _studentApi.GetOneStudent(8);

                Console.WriteLine("Student Name: " + data.student_name);
                Console.WriteLine("Student Age: " + data.student_age);
                Console.WriteLine("Join Date: " + data.join_date);
                Console.WriteLine("Student Year: " + data.student_year);
                Console.WriteLine("Target Major: " + data.major);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task CreateStudentAsync(string student_name, int student_age, int student_year, string join_date, string major)
        {
            StudentModel student = new StudentModel()
            {
                student_name = student_name,
                student_age = student_age,
                student_year = student_year,
                join_date = join_date,
                major = major
            };

            var message = await _studentApi.CreateStudent(student);

            Console.WriteLine(message);
        }

        private async Task UpdateStudentAsync(int id, string student_name, int student_age, int student_year, string join_date, string major)
        {
            try
            {
                StudentModel student = new StudentModel()
                {
                    student_name = student_name,
                    student_age = student_age,
                    student_year = student_year,
                    join_date = join_date,
                    major = major
                };

                var message = await _studentApi.UpdateStudent(id, student);
                Console.WriteLine(message);
            } 
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }

        private async Task DeleteAsync(int id)
        {
            try
            {
                var message = await _studentApi.DeleteStudent(id);
                Console.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
