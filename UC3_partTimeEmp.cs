using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
  public  class UC3_partTimeEmp
    {
        public static void PartTimeEmp()
        {
            //constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 20;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 3);
            if (empCheck==IS_PART_TIME)
            {
                empHrs = 4;

            }
            else if (empCheck==IS_FULL_TIME)
            {
                empHrs = 8;


            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("employee Wage:" + empWage);
        }

    }
}
