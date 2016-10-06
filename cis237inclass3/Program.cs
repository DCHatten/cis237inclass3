using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee sEmployee = new SalaryEmployee("David", "Barnes", new DateTime(2014, 10, 31), 537.36m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee.GetAllEmployeeInformation());

            HourlyEmployee hEmployee = new HourlyEmployee("Joe", "Smith", new DateTime(2013, 10, 1), 12.43m, 36m);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetAllEmployeeInformation());
            //Create an IEmployee Collection of Employee Collection Type
            IEmployeeCollection employeeCollection = new EmployeeCollection();
            //Call the AddNewEmployees method to add to the collection
            AddNewEmployees(employeeCollection);
            //Output the collection to the screen
            PrintEmployees(employeeCollection);
        }

        static void AddNewEmployees(IEmployeeCollection employeeCollection)
        {
            //Add a couple Salary Employees
            employeeCollection.Add("James", "Kirk", new DateTime(2016, 4, 4), 549m);
            employeeCollection.Add("Jean-Luc", "Picard", new DateTime(2016, 5, 14), 609m);
            //Add a couple Hourly Employees
            employeeCollection.Add("Benjamin", "Sisko", new DateTime(2016, 4, 4), 49m, 40);
            employeeCollection.Add("Johnathon", "Archer", new DateTime(2016, 4, 4), 54m, 20);
        }

        static void PrintEmployees(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine(employeeCollection.GetPrintString());
        }
    }
}
