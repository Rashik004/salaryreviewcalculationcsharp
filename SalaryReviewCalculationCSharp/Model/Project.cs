using SalaryReviewCalculationCSharp.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    public class Project:SalaryEntity
    {
        public List<Team> Members { get; set; }
        public Project()
        {
            Members = new List<Team>();
            calculator = new ProjectCalculator(this);
        }

    }
}
