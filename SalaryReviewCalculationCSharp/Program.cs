
using SlaryReviewCalculationCSharp.Calculator;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaryReviewCalculationCSharp
{
    using SalaryReviewCalculationCSharp;
    using SalaryReviewCalculationCSharp.HelperClass;
    using SalaryReviewCalculationCSharp.Model;

    class Program
    {
        static void Main(string[] args)
        {
            

            var devScore = HelperClass.GetDevScore();

            var tlScore = HelperClass.GetTlScore();

            var team1Lead = new Employee() { Name = "Team 1 Lead", Salary = 10, Score = tlScore, Role = EmployeeRole.TeamLead};
            var team2Lead = new Employee() { Name = "Team 2 Lead", Salary = 100, Score = tlScore, Role = EmployeeRole.TeamLead};
            var dev12 = new Employee() { Name = "dev12", Salary = 20, Score = devScore, Role = EmployeeRole.Developer};


            var dev21 = new Employee() { Name = "dev21", Salary = 30, Score = devScore, Role = EmployeeRole.Developer};
            var dev22 = new Employee() { Name = "dev22", Salary = 40, Score = tlScore, Role = EmployeeRole.Developer};


            var dev31 = new Employee() { Name = "dev31", Salary = 30, Score = devScore, Role = EmployeeRole.Developer };
            var dev32 = new Employee() { Name = "dev32", Salary = 40, Score = tlScore, Role = EmployeeRole.Developer };
            var team1=new Team()
            {
                Name = "Team1",
                TeamLead = team1Lead,
                Members = new List<Employee>() { dev12 }
            };

            var team2 = new Team()
            {
                Name = "Team2",
                TeamLead = team2Lead,
                Members = new List<Employee>() { dev21, dev22 }
            };

            var team3 = new Team()
            {
                Name = "Team3",
                TeamLead = dev31,
                Members = new List<Employee>() { dev32 }
            };


            var project = new Project()
            {
                Name = "Blockbonds",
                Members = new List<Team>() { team1, team3 }

            };
            var showables = new List<SalaryEntity>();
            showables.Add(dev12);
            showables.Add(team2);
            showables.Add(project);
            Console.WriteLine("Printing starts");
            foreach (var showable in showables)
            {
                Console.WriteLine();
                Console.WriteLine();
                showable.Show();
            }
            Console.ReadKey();


            
        }

        
    }
}
