using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageAssignment
{
    public interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth);
        public void ComputeEmpWage();
        public int GetTotalWage(string company);
    }

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
            this.totalEmpWage = 0;
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

    internal class EmpWageBuilder: IComputeEmpWage
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        //private int _numOfCompany = 0;
        //private CompanyEmpWage[] _companyEmpWageArray;

        private LinkedList<CompanyEmpWage> _companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> _companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this._companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this._companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(
                company, empRatePerHour, numOfWorkingDays, maxHrsPerMonth);
            this._companyEmpWageList.AddLast(companyEmpWage);
            this._companyToEmpWageMap.Add(company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {

            foreach (CompanyEmpWage companyEmpWage in this._companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage);
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

        public int GetTotalWage(string company)
        {
            return this._companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
