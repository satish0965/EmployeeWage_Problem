using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class EmployeeWage
    {
        public static void EmployeeCheckAttendance()
        {
            //define constants
            int IS_FULL_TIME = 1;

            //random function is to create random numbers
            Random random = new Random();
            //
            int empCheck = random.Next(0, 2);
            //use if else statement to check if employee is present or absent

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}