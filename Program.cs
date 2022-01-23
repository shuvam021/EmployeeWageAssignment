using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart);
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance);
        }
    }
}
