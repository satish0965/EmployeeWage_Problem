using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class EmployeeWage
    {

        //When using switch case define constants in class

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int Emp_Rate_Per_Hr = 20;
        public static void EmpWageSwitch()
        {

            //variables
            int empHrs = 0;
            int empWage = 0;

            //random function is to create random numbers
            Random random = new Random();
            //
            int empCheck = random.Next(0, 2);

            //use Switch case statement to get employee wage

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
            empWage = empHrs * Emp_Rate_Per_Hr;

            Console.WriteLine("Emp Wage" + empWage);
        }
    }
}