﻿using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
   public class UC2_EmpWage
    {
        public static void EmpWage()
        {
            //constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //VARIABLES
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck==IS_FULL_TIME)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;
            }
        
        empWage=empHrs* EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage:"+empWage);;
    }
}
}
