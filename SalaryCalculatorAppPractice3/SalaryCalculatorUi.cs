using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        EmployeeSalary employeeSalary = new EmployeeSalary();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            string name = employeeNameTextBox.Text;
            double basicSalary =Convert.ToDouble(basicAmountTextBox.Text);
            double houseRent = Convert.ToDouble(homeRentTextBox.Text);
            double medicleAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double totalSalary = employeeSalary.salaryCalculation(basicSalary, houseRent, medicleAllowance);
            MessageBox.Show("Employee Name : " + name + ", Employee Total Salary : "+ totalSalary + " ");

        }
    }
}
