using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        private const int IsPartTime = 1;
        private const int IsFullTime = 2;
        private const int EmpRatePerHour = 20;
        private const int NumOfWorkingDays = 20;
        private const int MaxHrsInMonth = 100;
        private static Random s_random = new Random();
        static void Main(string[] args)
        {
            int totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= MaxHrsInMonth && totalWorkingDays < NumOfWorkingDays)
            {
                totalWorkingDays++;
                int empCheck = s_random.Next(0, 3);
                int empHrs = 0;
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
                totalEmpHrs += empHrs;
                Console.WriteLine($"Days: {totalWorkingDays} Emp Hrs: {empHrs}");
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine($"Total Emp Wage: {totalEmpWage}");
        }
    }
}
