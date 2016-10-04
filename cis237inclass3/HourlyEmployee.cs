using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        //Backing fields
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;
        //Properties
        public decimal WeeklySalary
        {
            get { return this._hourlyRate * this._hoursPerWeek; }
        }
        //Methods
        public override string ToString()
        {
            return base.ToString() + " " + this.WeeklySalary.ToString("C");
        }
        public string NameAndSalary()
        {
            return base.ToString() + " " + this.WeeklySalary.ToString("C");
        }
        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.GetYearlySalary().ToString("C");
        }
        public override decimal GetYearlySalary()
        {
            return this.WeeklySalary * 52;
        }
        //Constructors
        public HourlyEmployee(string firstName, string lastName, DateTime startDate, decimal hourlyRate, 
            decimal hoursPerWeek) : base(firstName, lastName, startDate)
        {
            _hourlyRate = hourlyRate;
            _hoursPerWeek = hoursPerWeek;
        }
        public HourlyEmployee() : base()
        {
            //Default Constructor
        }
    }
}
