using System;
using System.Collections.Generic;
using System.Text;

namespace wage_problems
{
   public class UC10_AbilityTomanageEmp
    {
        public class EmpWageBuilderArray
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            public int NumOfCompany = 0;
            private CompanyEmpWage[] companyEmpWageArray;
            public EmpWageBuilderArray()
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];

            }
            public void addCompanyEmpWage(string company, int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
            {
                companyEmpWageArray[this.NumOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                NumOfCompany++;
            }
            public void computeEmpWage()
            {
                for (int i = 0; i < NumOfCompany; i++)
                {
                    companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());

                }
            }

            private object computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                throw new NotImplementedException();
            }

            private int computeEmpWage(companyEmpWage companyEmpWage)
            {
                int empHrs = 0;int totalEmpHrs = 0;
                int totalWorkingSays = 0;
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                    string totalWorkingDays = null;
                    Console.WriteLine("day#:" + totalWorkingDays + "Emp Hours" + empHrs);

                }







                return totalEmpHrs * companyEmpWage.empRatePerHour;

            }
        }
        }

    class CompanyEmpWage
    {
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        internal void setTotalEmpWage(object v)
        {
            throw new NotImplementedException();
        }

        internal bool toString()
        {
            throw new NotImplementedException();
        }
    }
}

