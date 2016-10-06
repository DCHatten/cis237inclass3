using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class EmployeeCollection : IEmployeeCollection
    {
        //You can declare an IEmployee array of Employee type, because you're 
        //not declaring individual instances of the Abstract type.
        IEmployee[] employees = new Employee[10];

        int currentIndex;

        //Constructor
        public EmployeeCollection()
        {
            currentIndex = 0;
        }

        public void Add(string FirstName, string LastName, DateTime StartDate, decimal Salary)
        {
            employees[currentIndex++] = new SalaryEmployee(FirstName, LastName, StartDate, Salary);
        }

        public void Add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek)
        {
            employees[currentIndex++] = new HourlyEmployee(FirstName, LastName, StartDate, HourlyRate, HoursPerWeek);
        }

        public string GetPrintString()
        {
            string allOutput = "";
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    allOutput += employee.ToString() + Environment.NewLine;
                    //Comparing the current employee type to SalaryEmployee
                    if (employee.GetType() == typeof(SalaryEmployee))
                    {
                        //Downcasting the employee to a SalaryEmployee to call the SalaryEmployee
                        //specific method NameAndSalary()
                        allOutput += ((SalaryEmployee)employee).NameAndSalary() + Environment.NewLine;
                    }
                    if (employee.GetType() == typeof(HourlyEmployee))
                    {
                        allOutput += ((HourlyEmployee)employee).NameAndSalary() + Environment.NewLine;
                    }
                }
            }
            return allOutput;
        }
    }
}
