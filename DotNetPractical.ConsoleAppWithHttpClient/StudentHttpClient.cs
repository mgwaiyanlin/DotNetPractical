
using Newtonsoft.Json;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace DotNetPractical.ConsoleAppWithHttpClient
{
    internal class StudentHttpClient
    {
        private readonly HttpClient _client = new HttpClient() { BaseAddress = new Uri("https://localhost:7122/") };
        private readonly string _studentEndPoint = "api/student/";

        public async Task Run()
        {
            await UpdateStudentAsync(7, "Roronora Zoro", 28, 2000, "September 2000", "Samurai");
        }

        private async Task ReadAllStudentsAsync()
        {
            var response = await _client.GetAsync(_studentEndPoint+"get_all_students");

            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();

                List<StudentDto> students = JsonConvert.DeserializeObject<List<StudentDto>>(jsonString)!;

                foreach (StudentDto student in students)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(student));
                }

            }
        }

        private async Task ReadStudentAsync(int id)
        {
            var response = await _client.GetAsync(_studentEndPoint + "get_a_student/"+id);
           
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
       
                var student = JsonConvert.DeserializeObject<StudentDto>(jsonString);

                Console.WriteLine(JsonConvert.SerializeObject(student));
            } else
            {
                Console.WriteLine("Failed to fetch...");
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
        }

        private async Task CreateStudentAsync (string student_name, int student_age, int student_year, string join_date, string major)
        {
            StudentDto studentDto = new StudentDto()
            {
                student_name = student_name,
                student_age = student_age,
                student_year = student_year,
                join_date = join_date,
                major = major
            };

            string studentJsonString = JsonConvert.SerializeObject(studentDto);
            HttpContent content = new StringContent(studentJsonString, Encoding.UTF8, Application.Json);
            var response = await _client.PostAsync(_studentEndPoint+"add_new_students",content);

            if (response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
            else
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }

        }

        private async Task UpdateStudentAsync(int id, string student_name, int student_age, int student_year, string join_date, string major)
        {
            StudentDto studentDto = new StudentDto()
            {
                student_name = student_name,
                student_age = student_age,
                student_year = student_year,
                join_date = join_date,
                major = major
            };

            string studentJsonString = JsonConvert.SerializeObject(studentDto);
            HttpContent httpContent = new StringContent(studentJsonString, Encoding.UTF8, Application.Json);
            var response = await _client.PutAsync(_studentEndPoint+"update/"+id, httpContent);

            if (response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
            else
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.WriteLine(message);
            }
        }

        private async Task DeleteStudentAsnyc(int id)
        {
            var response = await _client.DeleteAsync(_studentEndPoint + "delete/" + id);

            if (response.IsSuccessStatusCode)
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.Write(message);
            } else
            {
                string message = await response.Content.ReadAsStringAsync();
                Console.Write(message);
            }
        }
    }
}
