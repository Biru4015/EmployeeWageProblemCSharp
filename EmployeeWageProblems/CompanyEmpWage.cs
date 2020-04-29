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
        /// This method is created for compute monthly wage of Employee
        /// </summary>
        /// <returns>monthlywage</returns>
        public string ComputeEmployeeWage()
        {
             //varialble
             int totalEmpHrs = 0;
             int totalWorkingDays = 0;
             int empHr = 0;
             int monthlySalary = 0;

            while (totalEmpHrs < maxHrs && totalWorkingDays < numOfDays)
            {
                Random random = new Random();
                int checkAttendance = (random.Next() % 3) + 1;
                empHr = GetWorkingHour(checkAttendance);
                totalEmpHrs = totalEmpHrs + empHr;
                totalWorkingDays++;
            }
            monthlySalary = empRate * totalEmpHrs;
             return "Day " + totalWorkingDays + " Employee wage of " + companyName + " is " + monthlySalary;
        }
    }
}