using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    //Supposed to act as Base Classes
    //Cannot create a instance of a abstract class
    public abstract  class Employee
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }

        public float BasicPay { get; set; }

        public Employee() {
            Console.WriteLine("Constructor of base class");
        }

        //protected allows the member to be available for same class
        //or to the classes that inherit from it
        //protected internal allows the member to be avaialable
        //for the same class or any classes that inherit from it
        //with in the same project/assembly
        protected internal float CalculateTax(float salary)
        {
            float tax = 0;

            if (salary >= 200000 && salary < 500000)
                tax = .10F;
            else if (salary >= 500000 && salary < 700000)
                tax = .20F;
            else if (salary >= 700000)
                tax = .30F;

            return tax;
        }
        //Virtual indicates that the method can be overriden in
        //Child classes
        public virtual float CalculateSalary()
        {
            float baseSalary    = BasicPay + (BasicPay * .10F);

            float finalSalary   = baseSalary -
                                  (baseSalary * CalculateTax(baseSalary));
            return finalSalary;
        }

        //Abstract method are those defined in the base class
        //Which does not have a implementation
        //All child classes are required to provide their on implementation
        abstract public void DisplaySalaryInfo();
    }

    public  class JuniorSoftwareEngineer : Employee{
        public JuniorSoftwareEngineer()
        {
            Console.WriteLine("Constuctor of Junior Software Engineer");
        }

        public override void DisplaySalaryInfo()
        {
            Console.WriteLine($"Base Salary : {BasicPay} \n" +
                              $"Net After Tax : {CalculateSalary()}");
        }
    }
    public class SeniorSoftwareEngineer : Employee{
        public override void DisplaySalaryInfo()
        {
            Console.WriteLine($"Base Salary : {BasicPay} \n" +
                              $"Net After Tax : {CalculateSalary()}");
        }
    }
    public class ProjectManager : Employee
    {
        public float ProjectBonus { get; set; }

        public override float CalculateSalary()
        {
            var projectManagerSalary = base.CalculateSalary()
                + ProjectBonus;

            projectManagerSalary = projectManagerSalary 
                                 - CalculateTax(ProjectBonus);

            return projectManagerSalary;
            
        }

        public override void DisplaySalaryInfo()
        {
            Console.WriteLine($"Base Salary   : {BasicPay} \n" +
                              $"Project Bonus : {ProjectBonus} \n" +
                              $"Net After Tax : {CalculateSalary()}");
        }

    }

    //Sealed : Prevent the class from being inherited
    sealed public class SeniorProjectManager :  ProjectManager
    {

    }

    public class DeliveryHeadManager : ProjectManager
    {

    }
}
