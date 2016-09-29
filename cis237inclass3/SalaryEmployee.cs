using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //Backing Fields
        private decimal _weeklySalary;
        //Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }
        //Methods
        public string NameAndSalary()
        {
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }
        //Constructor
        public SalaryEmployee(string FirstName, string LastName, DateTime StartDate, 
            decimal WeeklySalary) : base(FirstName,LastName,StartDate)
        {
            _weeklySalary = WeeklySalary;
        }
        public SalaryEmployee() : base()
        {
            //Default Constructor
        }
    }
}
