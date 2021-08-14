using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
   public class UC4_EmpWageUsingSwitch
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmpWageUsingSwitch()
        {
            //variables
            int empHrs = 0;
            int EmpWage = 0;
            Random random = new Random();
            //computations
            int empCheck = random.Next(0, 3);
            switch (empCheck)
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
            EmpWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("employee wage:" +EmpWage);
        }



    }
}
