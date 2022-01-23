using System;

namespace EmployeeWageAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine($"Total wage for Dmart company: {empWageBuilder.GetTotalWage("DMart")}");
        }
    }
}
