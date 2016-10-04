using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    //This is an abstract class.  It cannot be instanciated, but it provides some methods/constructors for child classes
    abstract class Employee : IEmployee
    {
        //Backing fields
        protected string _firstName;
        protected string _lastName;
        protected DateTime _startDate;
        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        //Methods
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
        public int GetEmploymentDurationinYears()
        {
            //Subtract the ticks of the start date from today, then get the days and divide by 365
            return new TimeSpan(DateTime.Now.Ticks - this._startDate.Ticks).Days / 365;
        }
        public virtual string GetAllEmployeeInformation()
        {
            //Compile and concatenate all the properties of the employee into a single line for readability
            return this._firstName + " " + this._lastName + " " + this.GetEmploymentDurationinYears() + " year(s)";
        }
        //Get the yearly salary of the employee
        //Make the method abstract so that all children will need to implement the method
        public abstract decimal GetYearlySalary();
        //Constructors
        public Employee(string FirstName, string LastName, DateTime StartDate)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _startDate = StartDate;
        }
        public Employee()
        {
            //Default Constructor
        }
    }
}
