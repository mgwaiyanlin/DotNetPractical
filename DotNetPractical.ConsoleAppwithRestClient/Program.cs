
using DotNetPractical.ConsoleAppwithRestClient;

Console.WriteLine("Console App using Rest Client is running...");


StudentRestClient studentRestClient = new StudentRestClient();
await studentRestClient.Run();

Console.ReadLine();

