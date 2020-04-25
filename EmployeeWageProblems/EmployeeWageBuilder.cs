using System;

namespace EmployeeWageProblems
{
    /// <summary>
    /// This conatains the code for welcome message for Employee wage problem
    /// </summary>
    class EmployeeWageBuilder
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

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
        /// This methos is created for calculate employee wage
        /// </summary>
        public static void ComputeEmployeeWage(String company,int empRate,int numOFDays,int maxHrs )
        {
            int monthlySalary = 0;
            while (totalEmpHrs<maxHrs  && totalWorkingDays < numOFDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int rand = (random.Next() % 3) + 1;
                empHr = GetWorkingHour(rand);
                totalEmpHrs = totalEmpHrs + empHr;
            }
            monthlySalary = empRate * totalEmpHrs;
            Console.WriteLine("Day "+totalWorkingDays+" Employee of a company is "+company+" is "+monthlySalary);
        }

        /// <summary>
        /// This is main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Employee wage Problem");
            ComputeEmployeeWage("BridgeLabz",25,22,90);
            ComputeEmployeeWage("Flipkart", 40, 18, 100);
            ComputeEmployeeWage("Amazon", 45, 24, 110);
            ComputeEmployeeWage("ThoughtWorks", 30, 20, 110);
        }
    }
}