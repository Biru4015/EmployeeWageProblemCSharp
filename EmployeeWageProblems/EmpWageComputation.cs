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
            int isPresent = 1;
            int salary = 0;
            Random random = new Random();
            if (random.Next() % 2 == isPresent)
            {
                Console.WriteLine("Employee is Present");
                int empWagePerHr = 20;
                int empHr = 8;
                salary = empWagePerHr * empHr;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                salary = 0;
            }
        }
    }
}
