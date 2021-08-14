using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
   public class UC8_EmpWageForMultipleCompanies
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
      
        public static int ComputeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHourPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHourPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();

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

                totalEmpHrs += empHrs;
                Console.WriteLine("day#:" + totalWorkingDays + "emp Hours" + empHrs);

            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("total emp wage for company:"  + company+"is"+ totalEmpWage);
            return totalEmpWage;

        }
    }
}

    

