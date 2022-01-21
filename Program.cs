using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        const int IsPartTime = 1;
        const int IsFullTime = 2;
        const int EmpRatePerHour = 20;
        private static int _empHrs = 0;
        private static int _empWage = 0;
        public static Random random = new Random();
        static void Main(string[] args)
        {
            int empCheck = random.Next(0, 3);
            if (empCheck == IsPartTime) _empHrs = 4;
            if (empCheck == IsFullTime) _empHrs = 8;
            _empWage = _empHrs * EmpRatePerHour;
            System.Console.WriteLine($"Emp Wage: {_empWage}");
        }
    }
}
