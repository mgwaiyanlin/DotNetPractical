using RestSharp;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace DotNetPractical.ConsoleAppwithRestClient
{
    internal class StudentRestClient
    {
        private readonly RestClient _client = new RestClient(new Uri("https://localhost:7122/"));
        private readonly string _studentEndPoint = "api/student";

        public async Task Run()
        {
            Console.WriteLine("Before Adding New Data");
            await ReadAllStudentsAsync();

            Console.WriteLine("After Adding New Data");
            await DeleteStudentAsync(9);
            await ReadAllStudentsAsync();

        }

        private async Task ReadAllStudentsAsync()
        {
            // -------------- Option 1: To Get Data --------------
            //RestRequest request = new RestRequest($"{_studentEndPoint}/get_all_students");
            //var response = await _client.GetAsync( request );

            // -------------- Option 2: To Get Data --------------
            RestRequest request = new RestRequest($"{_studentEndPoint}/get_all_students", Method.Get);
            var response = await _client.ExecuteAsync(request);

            if (response.IsSuccessStatusCode)
            {
                string studentJsonString = response.Content!;
                List<StudentDto> students = JsonConvert.DeserializeObject<List<StudentDto>>(studentJsonString)!;

                foreach (var student in students)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(student));
                }
            }
        }

        private async Task ReadAStudentAsync(int id)
        {
            RestRequest restRequest = new RestRequest($"{_studentEndPoint}/get_a_student/{id}", Method.Get);
            var response = await _client.ExecuteAsync(restRequest);

            if (response.IsSuccessStatusCode)
            {
                string aStudentJsonString = response.Content!;
                var student = JsonConvert.DeserializeObject<StudentDto>(aStudentJsonString)!;

                Console.WriteLine(JsonConvert.SerializeObject(student));
            } else
            {
                string message = response.Content!;
                Console.WriteLine(message);
            }
        }

        private async Task CreateAStudentAsync(string student_name, int student_age, int student_year, string join_date, string major)
        {
            StudentDto student = new StudentDto()
            {
                student_name = student_name,
                student_age = student_age,
                student_year = student_year,
                join_date = join_date,
                major = major
            };

            var restRequest = new RestRequest($"{_studentEndPoint}/add_new_students", Method.Post);
            restRequest.AddJsonBody(student);
            var response = await _client.ExecuteAsync(restRequest);

            if (response.IsSuccessStatusCode)
            {
                string message = response.Content!;
                Console.WriteLine(message);
            }
            else
            {
                string message = response.Content!;
                Console.WriteLine(message);
            }
        }

        private async Task UpdateAStudentAsync(int id, string student_name, int student_age, int student_year, string join_date, string major)
        {
            StudentDto student = new StudentDto()
            {
                student_name = student_name,
                student_age = student_age,
                student_year = student_year,
                join_date = join_date,
                major = major
            };

            var restRequest = new RestRequest($"{_studentEndPoint}/update/{id}", Method.Put);
            restRequest.AddJsonBody(student);
            var response = await _client.ExecuteAsync(restRequest);

            if (response.IsSuccessStatusCode)
            {
                string message = response.Content!;
                Console.WriteLine(message);
            }
            else
            {
                string message = response.Content!;
                Console.WriteLine(message);
            }
        }

        private async Task DeleteStudentAsync(int id)
        {
            var restRequest = new RestRequest($"{_studentEndPoint}/delete/{id}" , Method.Delete);
            var response = await _client.ExecuteAsync(restRequest);

            if (response.IsSuccessStatusCode)
            {
                var message = response.Content!;
                Console.WriteLine(message);
            }
        }
    }
}
