using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    using SalaryReviewCalculationCSharp.Contract;
    using SlaryReviewCalculationCSharp.Calculator;

    public class Employee:SalaryEntity
    {
        
        //public Team Team { get; set; }
        public double Salary { get; set; }
        public Score Score { get; set; }

        public EmployeeRole Role { get; set; }

        public Employee()
        {
            calculator = new EmployeeCalculator(this);
        }

    }
}
