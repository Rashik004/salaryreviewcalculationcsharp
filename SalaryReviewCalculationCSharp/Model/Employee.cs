using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    using SlaryReviewCalculationCSharp.Calculator;

    public class Employee:ModelBase
    {
        //public Team Team { get; set; }
        public double Salary { get; set; }
        public Score Score { get; set; }

        public EmployeeRole Role { get; set; }

    }
}
