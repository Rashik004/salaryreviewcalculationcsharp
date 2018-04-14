
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

            var employee12Calc = new EmployeeCalculator(dev12);
            employee12Calc.Print();

            var team2Calc = new TeamCalculator(team2);
            team2Calc.Print();
            Console.ReadKey();


            /*var devScore = new Score
            {
                ProblemSolving = 8,
                YearsOfExperience = 3,
                LeaderShip = 2,
                Communication = 7,
                Decipline = 10
            };

            var dev1 = new Developer { Name = "Dev 1", TeamName = "GB", Salary = 10000, Score = empScore };
            var dev2 = new Developer { Name = "Dev 2", TeamName = "GB", Salary = 20000, Score = empScore };
            var dev3 = new Developer { Name = "Dev 3", TeamName = "GB", Salary = 30000, Score = empScore };

            var tlScore = new Score
            {
                ProblemSolving = 8,
                YearsOfExperience = 5,
                LeaderShip = 8,
                Communication = 8,
                Decipline = 9
            };
            var teamLead1 = new TeamLead { Name = "TL 1", ProjectName = "GB", Salary = 40000, Score = tlScore };
            
            Console.ReadLine();*/
        }

        
    }
}
