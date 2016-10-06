using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployeeCollection
    {
        void Add(string FirstName, string LastName, DateTime StartDate, decimal Salary);
        void Add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek);
        string GetPrintString();
    }
}
