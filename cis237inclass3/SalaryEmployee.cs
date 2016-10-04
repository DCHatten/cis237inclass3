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
        public override string ToString()
        {
            //Take the parents To String ouput and add the weekly salary
            return base.ToString() + " " + this._weeklySalary.ToString("C");
        }
        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.GetYearlySalary().ToString("C");
        }
        public override decimal GetYearlySalary()
        {
            //Override the abstract method in the parent class, which MUST be implemented
            return this._weeklySalary * 52;
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
