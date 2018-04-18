using SalaryReviewCalculationCSharp.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    public class Team : ModelBase, ICalculable
    {
        private TeamCalculator calculator;
        public Team()
        {
            Members=new List<Employee>();
            calculator = new TeamCalculator(this);
        }
        public Employee TeamLead { get; set; }

        public List<Employee> Members { get; set; }

      

        public void Show()
        {
            calculator.Print();
        }
    }
}
