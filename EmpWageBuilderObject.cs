using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageAssignment
{
    internal class EmpWageBuilderObject
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        private string _company;
        private int _empRatePerHour;
        private int _numOfWorkingDays;
        private int _maxHrsPerMonth;
        private int _totalEmpWage;
        public EmpWageBuilderObject(
            string company,
            int empRatePerHour,
            int numOfWorkingDays,
            int maxHrsPerMonth)
        {
            this._company = company;
            this._empRatePerHour = empRatePerHour;
            this._numOfWorkingDays = numOfWorkingDays;
            this._maxHrsPerMonth = maxHrsPerMonth;
        }
        public override string ToString()
        {
            return $"Total Emp Wage for company: {this._company} is {_totalEmpWage}";
        }

        public void ComputeEmpWage()
        {
            int totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= this._maxHrsPerMonth && totalWorkingDays < this._numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                int empHrs = 0;
                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine($"Day#: {totalWorkingDays}, Emp Hrs: {empHrs}");
            }
            this._totalEmpWage = totalEmpHrs * this._empRatePerHour;
            Console.WriteLine($"Total Emp Wage for company: {this._company} is: {this._totalEmpWage}");
        }
    }
}
