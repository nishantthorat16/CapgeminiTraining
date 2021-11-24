using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace SerializationSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));

            /*List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            Console.Write("Enter Id :");
            employee.Id         = int.Parse(Console.ReadLine());

            Console.Write("Name :");
            employee.Name       = Console.ReadLine();

            Console.Write("Email :");
            employee.Email      = Console.ReadLine();

            Employee employee2 = new Employee();
            employee2.Name = "Bill";
            employee2.Email = "bill@gmail.com";
            employee2.Id = 100002;

            employees.Add(employee);
            employees.Add(employee2);

            /*
             1. Xml
             2. Binary
             3. JSON 
             */
            //Serialize - > Convert Object data to another form so that it can be saved in a file

            /*
            Stream stream               = new FileStream(@"D:\Capgemini Training\EmployeeDetails.xml"
                                                            ,FileMode.OpenOrCreate
                                                            ,FileAccess.ReadWrite);
            xmlSerializer.Serialize(stream, employees);

            stream.Close();
            */
            Stream readStream = new FileStream(@"D:\Capgemini Training\EmployeeDetails.xml"
                                                           , FileMode.OpenOrCreate
                                                           , FileAccess.Read);

            List<Employee> list = (List<Employee>)xmlSerializer.Deserialize(readStream);
            foreach(var e in list)
                Console.WriteLine(e.Name);

            readStream.Close();

            IFormatter binaryFormatter = new BinaryFormatter(); //Format the data in binary
            Stream stream = new FileStream(@"D:\Capgemini Training\EmployeeDetails.bin"
                                                            , FileMode.OpenOrCreate
                                                            , FileAccess.ReadWrite);

            binaryFormatter.Serialize(stream, list);
            stream.Close();

           
            var serializedObject = JsonSerializer.Serialize(list);
            File.WriteAllText(@"D:\Capgemini Training\EmployeeDetails.json", serializedObject);

            var dataFromFile                = File.ReadAllText(@"D:\Capgemini Training\EmployeeDetails.json");
            List<Employee> deserializedList = JsonSerializer.Deserialize<List<Employee>>(dataFromFile);
        }
    }
}
