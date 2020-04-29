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
        /// Creating arraylist of multiple compnies.
        /// </summary>
        public static ArrayList companyarray = new ArrayList();

        /// <summary>
        /// This method is created for finding monthly wage of a company
        /// </summary>
        /// <param name="companyName"></param>
        public static void GetTotalWageByCompany(String companyName)
        {

            foreach(CompanyEmpWage companyWage in companyarray)
            {
                if(companyWage.ComputeEmployeeWage().Contains(companyName))
                {
                    Console.WriteLine(companyWage.ComputeEmployeeWage());
                    break;   
                }
            }
        }

        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            Console.WriteLine();

            companyarray.Add(new CompanyEmpWage("Relaince", 20, 24, 120));
            companyarray.Add(new CompanyEmpWage("Jio", 25, 20, 100));
            companyarray.Add(new CompanyEmpWage("Flipkart", 30, 20, 110));
            companyarray.Add(new CompanyEmpWage("Jio", 40, 18, 90));
            companyarray.Add(new CompanyEmpWage("Google", 50, 20, 80));

            Console.Write("Enter the company name: ");
            string comapnyName = Console.ReadLine();
            GetTotalWageByCompany(comapnyName);
        }
    }
}