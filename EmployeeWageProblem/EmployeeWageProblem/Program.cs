using EmployeeWageProblem;
using System;

namespace EmployeeWageProblem
{
    public class program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 3");

            Console.WriteLine("Output of Total Employee wage for a Month  :");
            //Creating Object of the class to call in Main method
            //because method is non static

            EmployeeWage emp = new EmployeeWage();
            emp.ComputeEmpWage();
        }
    }
}