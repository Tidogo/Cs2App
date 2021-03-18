//      ----Change History for EmployeeDB->Employee.cs by Timothy Goddard----
// Date               Author                       Description
// 2/6/2021           Timothy Goddard              Initial creation with full functionality
// 2/6/2021           Timothy Goddard              Comments added

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    // this is the code for the Employee class
    class Employee
    {
        // class variables for the Employee class
        private string firstName;
        private string lastName;
        private decimal monthlySalary;

        // this is the constructor method for the Employee class
        public Employee(string fName, string lName, decimal mSalary)
        {
            firstName = fName;
            lastName = lName;
            monthlySalary = mSalary;
        }

        // this method will get and return the firstName class variable
        public string getFirstName()
        {
            return firstName;
        }

        // this method will get and return the lastName class variable
        public string getLastName()
        {
            return lastName;
        }

        // this method will get and return the monthlySalary class variable
        public decimal getMonthlySalary()
        {
            return monthlySalary;
        }

        // this method will set the firstName class variable
        public void setFirstName(string fName)
        {
            firstName = fName;
        }

        // this method will set the lastName class variable
        public void setLastName(string lName)
        {
            lastName = lName;
        }

        // this method will set the monthlySalary variable
        public void setMonthlySalary(decimal mSalary)
        {
            // if user tries to set a negative salary, ignore them
            if (!(mSalary <= 0))
            {
                monthlySalary = mSalary;
            }
        }
    }
}
