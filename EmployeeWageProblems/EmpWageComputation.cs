using System;

namespace EmployeeWageProblems
{
    /// <summary>
    /// This conatains the code for welcome message for Employee wage problem
    /// </summary>
    class EmpWageComputation
    {
        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            int isFullTime = 1;
            int isPartTime = 2;
            int salary = 0;
            int empWagePerHr = 20;
            int empHr = 4;
            Random random = new Random();
            int rand = (random.Next() % 2) + 1;
            if (rand == isPartTime)
                empHr = 4;
            else if (rand == isFullTime)
                empHr = 8;
            else
                empHr = 0;

            salary = empWagePerHr * empHr;
        }
    }
}
