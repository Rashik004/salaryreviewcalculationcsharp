using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryReviewCalculationCSharp.Model;
using SalaryReviewCalculationCSharp.Contract;


namespace SalaryReviewCalculationCSharp
{
    public abstract class SalaryEntity : ModelBase, ICalculable
    {
        protected BaseCalculator calculator;
        public void Show()
        {
            calculator.Print();
        }
    }
}
