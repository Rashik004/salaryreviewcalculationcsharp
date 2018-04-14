using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryReviewCalculationCSharp.HelperClass
{
    using System.Dynamic;

    using SalaryReviewCalculationCSharp.Model;

    using SlaryReviewCalculationCSharp.Calculator;

    public static class HelperClass
    {
        public static Impact EmployeeImpact(EmployeeRole role)
        {
            switch (role)
            {
                case EmployeeRole.Developer:
                    return GetDeveloperImpact();
                case EmployeeRole.TeamLead:
                    return GetTeamLeadImpact();
                default:
                    return null;
            }
        }

        private static Impact GetTeamLeadImpact()
        {
            return new Impact()
                       {
                           CommunicationImpact = .3,
                           DisciplineImpact = .2,
                           ExperienceImpact = .2,
                           LeadershipImpact = .2,
                           ProblemSolvingImpact = .2
                       };
        }

        private static Impact GetDeveloperImpact()
        {
            return new Impact()
            {
                CommunicationImpact = .34,
                DisciplineImpact = .2,
                ExperienceImpact = .4,
                LeadershipImpact = .5,
                ProblemSolvingImpact = .6
            };
        }

        public static Score GetDevScore()
        {
            return new Score
            {
                ProblemSolving = 8,
                YearsOfExperience = 5,
                LeaderShip = 8,
                Communication = 8,
                Decipline = 9
            };
        }

        public static Score GetTlScore()
        {
            return new Score
            {
                ProblemSolving = 3,
                YearsOfExperience = 7,
                LeaderShip = 9,
                Communication = 8,
                Decipline = 9
            };
        }
    }
}
