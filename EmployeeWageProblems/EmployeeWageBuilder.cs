using System;
using System.Collections;

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
            for (int index=1;index<=2;index++)
            {
                Console.WriteLine("Please enter the "+index+"st company details.");
                Console.Write("Enter the company name: ");
                String companyname = Console.ReadLine();
                Console.Write("Please enter the rate per hour: ");
                int empRate = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the maximum working days in a month: ");
                int numOfDays = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the max working hrs in a month: ");
                int maxHrs = Convert.ToInt32(Console.ReadLine());
                
                companyobj.Add( new CompanyEmpWage(companyname, empRate, numOfDays, maxHrs));

            }

            foreach(CompanyEmpWage item in companyobj)
            {
                item.ComputeEmployeeWage();
            }
        }
    }
}