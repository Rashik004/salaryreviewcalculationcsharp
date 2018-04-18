using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp
{
    using System.Runtime.InteropServices;

    using SalaryReviewCalculationCSharp.Model;

    using SlaryReviewCalculationCSharp.Calculator;
    using SalaryReviewCalculationCSharp.HelperClass;
    using SalaryReviewCalculationCSharp.Contract;

    public abstract class BaseCalculator
    {
        protected double CalculateReview(Employee employee)
        {
            var calculator = new ReviewCalculator()
                                 {
                                     Score = employee.Score,
                                     Salary = employee.Salary,
                                     Impact = HelperClass.HelperClass.EmployeeImpact(employee.Role)
                                 };
            return calculator.Calculate();
        }

        public abstract void Print();

        public ICalculable calculable;
    }
}
