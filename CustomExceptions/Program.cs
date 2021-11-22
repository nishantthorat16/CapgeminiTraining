using System;
using System.Collections.Generic;

namespace CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            try
            {
                Employee emp1 = new Employee();
                emp1.Name = "Sree";
                emp1.Age = 36;

                employees.Add(emp1);

                Employee emp2 = new Employee();
                emp2.Name = "001";
                emp2.Age = 36;

                employees.Add(emp2);

                Employee emp3 = new Employee();
                emp3.Name = "Bill";
                emp3.Age = 14;

                employees.Add(emp3);
            }
            catch(InvalidAgeException ageException)
            {
                Console.WriteLine("Age must be ateast 18 years : " + ageException.Message); 
            }
            catch(InvalidNameException nameException)
            {
                //Console.WriteLine(nameException.StackTrace);
                //Console.WriteLine("Name must contain only alphabets : " + nameException.Message);
                //1. throw new InvalidNameException(); CREATE A NEW EXCEPTION AND THROW
                //2. throw nameException; THROW THE EXCEPTION WITHOUT PRESERVING THE STACK TRACE
                //3. throw; THROW THE EXCEPTION BY PRESERVING THE STACK TRACE

                //throw nameException;
                Exception excp = new Exception("Error occured while enteing data",nameException);
                throw excp;
                //throw;
            }
            catch(Exception exp)
            {
              
                Console.WriteLine(exp.Message);
            }
            catch
            {
                Console.WriteLine("Empty catch statement");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
               
            
            foreach(Employee emp in employees)
                Console.WriteLine(emp.Name);

        }
    }
}
