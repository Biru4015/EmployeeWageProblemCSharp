using System;

namespace EmployeeWageProblems
{
    /// <summary>
    /// This conatains the code for welcome message for Employee wage problem
    /// </summary>
    class EmpWageComputation
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empWagePerHr = 20;
        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            int salary = 0;
            int empHr=0;
            Random random = new Random();
            int rand = (random.Next() % 3) + 1;
            switch(rand)
            {
                case isFullTime:
                    empHr=8;
                    break;
                case isPartTime:
                    empHr = 4;
                    break;
                default:
                    empHr = 0;
                    break;
                    
            }
            salary = empWagePerHr * empHr;
        }
    }
}
