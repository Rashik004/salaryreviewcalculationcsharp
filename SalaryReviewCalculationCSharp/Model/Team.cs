using SalaryReviewCalculationCSharp.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    public class Team : SalaryEntity
    {
        public Team()
        {
            Members=new List<Employee>();
            calculator = new TeamCalculator(this);
        }
        public Employee TeamLead { get; set; }

        public List<Employee> Members { get; set; }

    }
}
