//      ----Change History for EmployeeDB->Program.cs by Timothy Goddard----
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
    // this is the class that contains code which manipulates & tests the Employee class
    class Program
    {
        // this main method creates new employee objects, manipulates them, and displays their data.
        static void Main(string[] args)
        {
            // this block of code informs the user of the program's purpose and then creates 3
            // new employee objects
            Console.WriteLine("This program will create 3 employees, display their salaries," +
                " give them raises, and then display their new salaries.");
            Console.WriteLine("Creating new employees...");
            Employee johnDoe = new Employee("John", "Doe", 7500);
            Employee janeDoe = new Employee("Jane", "Doe", 8000);
            Employee bruceLee = new Employee("Bruce", "Lee", 10000);

            // display the 3 employee's yearly salaries
            Console.WriteLine(johnDoe.getFirstName() + "'s salary: " + johnDoe.getMonthlySalary() * 12);
            Console.WriteLine(janeDoe.getFirstName() + "'s salary: " + janeDoe.getMonthlySalary() * 12);
            Console.WriteLine(bruceLee.getFirstName() + "'s salary: " + bruceLee.getMonthlySalary() * 12);

            // give all employees a raise of 10%
            Console.WriteLine("Giving all employees 10% raise...");
            johnDoe.setMonthlySalary(johnDoe.getMonthlySalary() * (decimal)1.10);
            janeDoe.setMonthlySalary(janeDoe.getMonthlySalary() * (decimal)1.10);
            bruceLee.setMonthlySalary(bruceLee.getMonthlySalary() * (decimal)1.10);

            // display the new salaries 
            Console.WriteLine(johnDoe.getFirstName() + "'s salary: " + johnDoe.getMonthlySalary() * 12);
            Console.WriteLine(janeDoe.getFirstName() + "'s salary: " + janeDoe.getMonthlySalary() * 12);
            Console.WriteLine(bruceLee.getFirstName() + "'s salary: " + bruceLee.getMonthlySalary() * 12);
            Console.WriteLine("Please enter any key to exit");
            Console.ReadLine();
        }
    }
}
