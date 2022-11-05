﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        //When using switch case define constants in class

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int IS_ABSENT = 0;
        public const int Emp_Rate_Per_Hr = 20;
        public const int Number_Of_Working_Days = 20;
        public const int Max_Hr_In_Month = 100;

        //Method is return type so it must return value
        public int ComputeEmpWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            ///While loop is used to check maximum working hours and number of working days.
            ///if it is true then it allows.
            while (totalEmpHrs <= Max_Hr_In_Month && totalWorkingDays < Number_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                //Switch case is used to check wheather employee is working as for part time or full time
                //according to that employee attendance employee hours will be taken.
                switch (random.Next(1, 3))
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_ABSENT:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;

                Console.WriteLine("Day " + totalWorkingDays + " : " + "Emp Hr: " + empHrs);
                empWage = Emp_Rate_Per_Hr * empHrs;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total EmpWage is :" + totalEmpWage);
            return totalEmpWage;

        }
    }

}