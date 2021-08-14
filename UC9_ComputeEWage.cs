using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
   public class UC9_ComputeEWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public static int ComputeEWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHourPerMonth;
        }
        public void computeWage()
        { 
        int empHrs = 0;
            int totalEmpHrs = 0;
                int totalWorkingDays=0;
            int maxHourPerMonth = 0;
            while (totalEmpHrs <= this. maxHourPerMonth && totalWorkingDays < this. numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();

                int empCheck = random.Next(0, 30);
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
                Console.WriteLine("day#:" + totalWorkingDays + "Emp Hours" + empHrs);

            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
           // Console.WriteLine("total emp wage for company:" + company + "is" + totalEmpWage);

            public string toString()
            {


                return "total Emp Wage For Company:"+this.company+"is " + this.totalEmpWage;
            }

        }
    }
}

    


    

