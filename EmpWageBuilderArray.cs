using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageAssignment
{
    internal class CompanyEmpWage {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHrsPerMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public override string ToString()
        {
            return $"Total Emp wage for Company: {this.company} is: {this.totalEmpWage}";
        }
    }
    internal class EmpWageBuilderArray
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        private int _numOfCompany = 0;
        private CompanyEmpWage[] _companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this._companyEmpWageArray = new CompanyEmpWage[5];
        }
        //public override string ToString()
        //{
        //    return $"Total Emp Wage for company: {this._company} is {_totalEmpWage}";
        //}

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            _companyEmpWageArray[this._numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHrsPerMonth);
            _numOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i< _numOfCompany; i++)
            {
                this._companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this._companyEmpWageArray[i]));
                Console.WriteLine(this._companyEmpWageArray[i]);
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
