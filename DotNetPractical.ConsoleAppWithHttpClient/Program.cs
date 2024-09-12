
namespace DotNetPractical.ConsoleAppWithHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application is running...");

            Thread workerThread = new Thread(CompressFile);
            workerThread.Start();

            Console.WriteLine("Other works in Main Thread!");
        }

        static void CompressFile()
        {
            Console.WriteLine("Started to compress your file...");
            Thread.Sleep(5000);
            Console.WriteLine("File compression is complete.");
        }
    }
}

