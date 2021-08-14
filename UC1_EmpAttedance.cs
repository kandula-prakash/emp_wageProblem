using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
    public class UC1_EmpAttedance
    {
        public static void EmpAttendance()
        {
            int IS_FULL_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_Time)
            {
                Console.WriteLine("employee is present");
            }

            else
            {
                Console.WriteLine("employee is not present");
                Console.ReadKey();
            }
            }
        }
    }


    

