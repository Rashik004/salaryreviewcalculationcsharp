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
            Console.WriteLine($"Team Lead review: {CalculateReview(this.team.TeamLead)}");
            foreach (var member in this.team.Members)
            {
                Console.WriteLine($"Salary of employee {member.Name} is {CalculateReview(member)}");
            }

        }
    }
}
