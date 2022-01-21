using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        private const int IsPartTime = 1;
        private const int IsFullTime = 2;
        private static Random s_random = new Random();
         public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            int totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
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
                Console.WriteLine($"Day#: {totalWorkingDays} Emp Hrs: {empHrs}");
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine($"Total Emp Wage for company: {company} is: {totalEmpWage}");
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
        }
    }
}
