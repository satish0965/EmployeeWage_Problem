using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class EmployeeWage
    {
        public static void EmpWagePartTime()
        {
            //define constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int Emp_Rate_Per_Hr = 20;

            //variables
            int empHrs = 0;
            int empWage = 0;

            //random function is to create random numbers
            Random random = new Random();
            //
            int empCheck = random.Next(0, 2);

            //use if else if statement to get employee wage
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}