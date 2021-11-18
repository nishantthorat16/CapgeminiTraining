using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();Cannot create the instance 
           ///because its abstract class
            
            var jse = new JuniorSoftwareEngineer();
            jse.FirstName = "Sreehari";
            jse.BasicPay  = 400000;
            

            var pm = new ProjectManager();
            pm.FirstName = "Mark";
            pm.BasicPay = 900000;
            pm.ProjectBonus = 50000;

            Console.WriteLine($"Salary of JSE {jse.CalculateSalary()}");
            Console.WriteLine($"Salary of PM  {pm.CalculateSalary()}");

        }
    }
}
