using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Employee
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
        public DayOfWeek GetStartDay()
        {
            return _startDate.DayOfWeek;
        }
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
