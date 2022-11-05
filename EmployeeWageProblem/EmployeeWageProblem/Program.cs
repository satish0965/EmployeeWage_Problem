﻿//Console.WriteLine("Welcome To Employee Wage Computation Problem");
using EmployeeWageProblem;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 For TATA Company Employee Wage");
            Console.WriteLine("2 For MAHINDRA Company Employee Wage");

            int problem = Convert.ToInt32(Console.ReadLine());
            switch (problem)
            {
                case 1:
                    EmployeeWageComputation employeewagecomputation = new EmployeeWageComputation();
                    employeewagecomputation.AddCompany("TATA", 20, 8, 4, 100, 20);
                    employeewagecomputation.CalculateEmpWage("TATA");
                    break;
                case 2:
                    EmployeeWageComputation wagecomputation = new EmployeeWageComputation();
                    wagecomputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
                    wagecomputation.CalculateEmpWage("MAHINDRA");
                    break;
            }
        }
    }
}