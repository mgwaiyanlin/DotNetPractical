
using DotNetPractical.ConsoleAppWithRefit;

Console.WriteLine("Console App with Refit");

RefitProgram refitProgram = new RefitProgram();
await refitProgram.RunAsync();

Console.WriteLine("Thank you for using this application.");
