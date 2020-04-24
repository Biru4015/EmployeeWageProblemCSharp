using System;

namespace EmployeeWageProblems
{
    /// <summary>
    /// This conatains the code for welcome message for Employee wage problem
    /// </summary>
    class EmpWageComputation
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        //varialble
        public static int totalEmpHrs = 0;
        public static int totalWorkingDays = 0;
        public static int empHr = 0;

        /// <summary>
        /// This method is created for getting employee working hour
        /// </summary>
        /// <returns>empHrs</returns>
        public static int GetWorkingHour(int rand)
        {
            int empHrs = 0;
            switch(rand)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            return empHrs;
        }
        
        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            int monthlySalary = 0;
            while(totalWorkingDays < MAX_HRS_IN_MONTH && totalWorkingDays < WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = (random.Next() % 3) + 1;
                empHr = GetWorkingHour(rand);
                totalEmpHrs = totalEmpHrs + empHr;
            }
            monthlySalary = EMP_WAGE_PER_HR * totalEmpHrs;
            Console.WriteLine("Total salary of employee in a month is "+monthlySalary);
        }
    }
}