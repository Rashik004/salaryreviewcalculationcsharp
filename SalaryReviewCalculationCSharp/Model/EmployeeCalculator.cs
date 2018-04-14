using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    public class EmployeeCalculator: BaseCalculator
    {
        private Employee _employee;
        public EmployeeCalculator(Employee employee)
        {
            this._employee = employee;
        }
        public override void Print()
        {
            Console.WriteLine($"Salary of {this._employee.Name} is {CalculateReview(this._employee)}");
        }
    }
}
