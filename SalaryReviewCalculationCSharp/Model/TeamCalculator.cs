using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp
{
    using SalaryReviewCalculationCSharp.Model;

    class TeamCalculator:BaseCalculator
    {
        private Team team;
        public TeamCalculator(Team team)
        {
            this.team = team;
        }
        public override void Print()
        {
            Console.WriteLine($"Review of team {this.team.Name} is given below");
            Console.WriteLine($"Review of team Lead is ");
            team.TeamLead.Show();
            Console.WriteLine($"Review of Members is ");
            foreach (var employee in team.Members)
            {
                employee.Show();
            }

        }
    }
}
