using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblems
{
    class CompanyEmpWage
    {
        

        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        //varialble
        public static int totalEmpHrs = 0;
        public static int totalWorkingDays = 0;
        public static int empHr = 0;


        //variable
        private String companyName;
        private int empRate;
        private int numOfDays;
        private int maxHrs;

        /// <summary>
        /// Initialize the paramters constructor
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="empRate"></param>
        /// <param name="numOfDays"></param>
        /// <param name="maxHrs"></param>
        public CompanyEmpWage(String companyName, int empRate, int numOfDays, int maxHrs)
        {
            this.companyName = companyName;
            this.empRate = empRate;
            this.numOfDays = numOfDays;
            this.maxHrs = maxHrs;
        }

        /// <summary>
        /// This method is created for getting employee working hour
        /// </summary>
        /// <returns>empHrs</returns>
        public static int GetWorkingHour(int checkAttendace)
        {
            int empHrs = 0;
            switch (checkAttendace)
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
        public void ComputeEmployeeWage()
        {
            int monthlySalary = 0;
            while (totalEmpHrs < maxHrs && totalWorkingDays < numOfDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int checkAttendance = (random.Next() % 3) + 1;
                empHr = GetWorkingHour(checkAttendance);
                totalEmpHrs = totalEmpHrs + empHr;
            }
            monthlySalary = empRate * totalEmpHrs;
            Console.WriteLine("Day " + totalWorkingDays + " Employee of a company is " + companyName + " is " + monthlySalary);
        }
    }
}
