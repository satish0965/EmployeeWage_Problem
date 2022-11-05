using EmployeeWageProblem;
using System;

namespace EmployeeWageProblem
{
    public class program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to EmpWageComputation problem");

            //so my class is static no need to instantiate/create object of class
            //directly call method

            Console.WriteLine("Output to get Employee is Part time or Full time using Switch case :");
            EmployeeWage.EmpWageSwitch();
        }
    }
}