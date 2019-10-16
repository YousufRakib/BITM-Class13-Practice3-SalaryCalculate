using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class EmployeeSalary
    {
        
        public double salaryCalculation(double basicSalary,double houseRent,double medicalAllowance)
        {
            double salaryCalculate = basicSalary + ((basicSalary * houseRent) / 100) + ((basicSalary * medicalAllowance) / 100);
            return salaryCalculate;
        }

    }
}
