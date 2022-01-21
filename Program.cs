using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        private const int IsPartTime = 1;
        private const int IsFullTime = 2;
        private const int EmpRatePerHour = 20;
        private static int _empHrs = 0;
        private static int _empWage = 0;
        private static Random s_random = new Random();
        static void Main(string[] args)
        {
            int empCheck = s_random.Next(0, 3);
            switch (empCheck)
            {
                case IsPartTime:
                    _empHrs = 4;
                    break;
                case IsFullTime:
                    _empHrs = 8;
                    break;
                default:
                    _empHrs = 0;
                    break;
            }
            _empWage = _empHrs * EmpRatePerHour;
            Console.WriteLine($"Emp Wage: {_empWage}");
        }
    }
}
