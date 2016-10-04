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
        }
    }
}
