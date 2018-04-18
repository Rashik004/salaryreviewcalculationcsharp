using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.Model
{
    class ProjectCalculator : BaseCalculator
    {
        private Project project;
        public ProjectCalculator(Project project)
        {
            this.project = project;
        }
        public override void Print()
        {
            Console.WriteLine($"Review of project {this.project.Name} is given below");
         
            foreach (var team in project.Members)
            {
                team.Show();
            }

        }
    }
}
