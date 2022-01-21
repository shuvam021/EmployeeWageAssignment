using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        const int IsFullTime = 1;
        const int EmpRatePerHour = 20;
        private static int _empHrs = 0;
        private static int _empWage = 0;
        public static Random RandomValue = new Random();
        static void Main(string[] args)
        {
            int empCheck = RandomValue.Next(0, 2);
            Console.WriteLine(empCheck == IsFullTime ? "Employee is present" : "Employee is Absent");
            if (empCheck == IsFullTime) _empHrs = 8;
            _empWage = _empHrs * EmpRatePerHour;
            System.Console.WriteLine($"Emp Wage: {_empWage}");
        }
    }
}
