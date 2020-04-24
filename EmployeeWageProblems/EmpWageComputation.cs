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
        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            int monthlySalary = 0;
            int empHr=0;
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            while(totalEmpHrs < MAX_HRS_IN_MONTH && totalEmpHrs < WORKING_DAYS)
            {
                totalWorkingDay++;
                Random random = new Random();
                int rand = (random.Next() % 3) + 1;
                switch(rand)
                {
                    case IS_PART_TIME:
                        empHr = 4;
                        break;
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHr;
            }
            monthlySalary = EMP_WAGE_PER_HR * totalEmpHrs;
            Console.WriteLine("Monthly salary of employee is "+monthlySalary);
        }
    }
}