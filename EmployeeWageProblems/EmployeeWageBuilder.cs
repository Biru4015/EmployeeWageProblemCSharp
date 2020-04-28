using System;
using System.Collections;
using EmployeeWageProblems;

namespace EmployeeWageProblems
{
    /// <summary>
    /// This conatains the code for welcome message for Employee wage problem
    /// </summary>
    class EmployeeWageBuilder
    {

        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            Console.WriteLine();

            ArrayList companyobj = new ArrayList();
            companyobj.Add( new CompanyEmpWage("Relaince", 20, 24, 120));
            companyobj.Add(new CompanyEmpWage("Jio", 25, 20, 100));
            companyobj.Add(new CompanyEmpWage("Flipkart", 30, 20, 110));
            companyobj.Add(new CompanyEmpWage("Jio", 40, 18, 90));
            companyobj.Add(new CompanyEmpWage("Google", 50, 20, 130));

            foreach (CompanyEmpWage item in companyobj)
            {
                item.ComputeEmployeeWage();
            }
        }
    }
}