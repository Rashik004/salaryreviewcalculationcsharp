using SalaryReviewCalculationCSharp.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    public class Project:ModelBase, ICalculable
    {
        public List<Team> Members { get; set; }
        private ProjectCalculator calculator;
        public Project()
        {
            Members = new List<Team>();
            calculator = new ProjectCalculator(this);
        }

        public void Show()
        {
            calculator.Print();
        }
    }
}
