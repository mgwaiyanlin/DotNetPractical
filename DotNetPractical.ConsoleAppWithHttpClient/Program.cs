using DotNetPractical.ConsoleAppWithHttpClient;
using Newtonsoft.Json;

Console.WriteLine("Console App is running...");

StudentHttpClient studentHttpClient = new StudentHttpClient();
await studentHttpClient.Run();

Console.ReadLine();



