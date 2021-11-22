using System;
using System.IO;
using System.Net;

namespace FilenDirectoryOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseDirectory = @"D:\Capgemini Training";
            var rootDirectory    = new DirectoryInfo(baseDirectory);
            /*
            foreach (DirectoryInfo di in rootDirectory.GetDirectories())
            {
                Console.WriteLine(di.Name);
                //Get the directories inside this directory
                DirectoryInfo directory = new DirectoryInfo(di.FullName);
                foreach (DirectoryInfo d in directory.GetDirectories())
                    Console.WriteLine($"\t-{d.Name}");
            }
            Console.Write("Enter a new directory name : ");
            string dirName = Console.ReadLine();

            //e.g images D:\Capgemini Training\images

            if (Directory.Exists(baseDirectory + "\\" + dirName))
                Console.WriteLine("Directory Already Exist");
            else
                Directory.CreateDirectory(baseDirectory + "\\" + dirName);*/

            /*
            foreach (FileInfo fi in rootDirectory.GetFiles("*.cs"))
            {
                Console.WriteLine($"File Name : {fi.Name}, Extention : {fi.Extension}, Size : {fi.Length}");
            }

            Console.Write("Enter the content you want to write :");
            string content = Console.ReadLine();

            Console.Write("Enter the file name : ");
            string filename = Console.ReadLine();

            string filePath = baseDirectory + "\\" + filename;
            //File.WriteAllText(filePath, content); //It will overrite the file contents;
            File.AppendAllText(filePath, content + "\n");

            string fileContentes = File.ReadAllText(filePath);
            Console.WriteLine($"-------------------------Contents of {filename}--------------------------");
            Console.WriteLine(fileContentes);*/

            WebClient client    = new WebClient();
            Stream stream       = client.OpenRead("https://www.ietf.org/rfc/rfc2616.txt");
            StreamReader reader = new StreamReader(stream);
            var fileContent     = reader.ReadToEnd();

            Console.WriteLine(fileContent);

            StreamWriter writer = new StreamWriter(@$"{baseDirectory}\filefromweb.txt");
            writer.WriteLine(fileContent);
            writer.Close();


            Stream imageStream = client.OpenRead("https://upload.wikimedia.org/wikipedia/commons/0/0f/Grosser_Panda.JPG");
            BinaryReader binaryReader = new BinaryReader(imageStream);
            var bytes = binaryReader.ReadBytes(Convert.ToInt32(imageStream));

            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(@$"{baseDirectory}\filefromweb.txt",FileMode.OpenOrCreate));
            binaryWriter.Write(bytes);
            binaryWriter.Close();

        }
    }
}
