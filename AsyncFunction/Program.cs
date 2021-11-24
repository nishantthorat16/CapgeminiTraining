using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initiating File Download");
            //var fileSyncName = DownloadFileSync();
            var fileName = DownloadFile()
                                .ContinueWith(ret => Console.WriteLine($"Downloaded file {ret.Result}"));


            //Console.Write($"Downloaded {fileName}");

            Console.WriteLine("Meanwhile tell me your name :");
            string name = Console.ReadLine();
            Console.WriteLine($"Hey {name} sorry the file is taking time");
            Console.ReadLine();
            
        }

        public static string DownloadFileSync()
        {
            Console.WriteLine("Starting to download file........");
            Thread.Sleep(10000);
            Console.WriteLine("Download Completed");
            return "myphoto.jpg";
        }

        public static async Task<string> DownloadFile()
        {
            Console.WriteLine("Starting to download file........");
            await Task.Delay(10000);
            Console.WriteLine("Download Completed");

            return "myphoto.jpg";
        }
    }
}
