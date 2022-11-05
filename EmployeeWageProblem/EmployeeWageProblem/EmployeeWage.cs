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
        public const int Number_Of_Working_Days = 20;
        public static void EmpWageSwitchForMonth()
        {

            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //Using for loop to iterate each day of working

            for (int day = 1; day < Number_Of_Working_Days; day++)
            {
                //random function is to create random numbers
                Random random = new Random();

                int empCheck = random.Next(0, 3);      //range from 0 to 2

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

                totalEmpWage += empWage;             //we can also use it totalEmpWage=totalEmpWage+empWage
                Console.WriteLine("Emp Wage : " + " " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + " " + totalEmpWage);
        }
    }
}