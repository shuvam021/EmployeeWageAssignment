using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        private const int IsPartTime = 1;
        private const int IsFullTime = 2;
        private const int EmpRatePerHour = 20;
        private const int NumOfWorkingDays = 20;
        private static Random s_random = new Random();
        static void Main(string[] args)
        {
             int totalEmpWage = 0;
            for (int day = 0; day < NumOfWorkingDays; day++)
            {
                int empWage = 0, empHrs = 0;
                int empCheck = s_random.Next(0, 3);
                switch (empCheck)
                {
                    case IsPartTime:
                        empHrs = 4;
                        break;
                    case IsFullTime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EmpRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine($"Emp Wage: {empWage}");
            }
            Console.WriteLine($"Total Emp Wage: {totalEmpWage}");
        }
    }
}
