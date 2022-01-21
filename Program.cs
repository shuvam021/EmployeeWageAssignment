using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        const int IsFullTime = 1;
        public static Random RandomValue = new Random();
        static void Main(string[] args)
        {
            int empCheck = RandomValue.Next(0, 2);
            Console.WriteLine(empCheck == IsFullTime ? "Employee is present" : "Employee is Absent");
        }
    }
}
