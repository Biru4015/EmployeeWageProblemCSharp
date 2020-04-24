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
            Random random = new Random();
            if (random.Next() % 2 == isPresent)
                Console.WriteLine("Employee is Present");
            else
            Console.WriteLine("Employee is Absent");
        }
    }
}
