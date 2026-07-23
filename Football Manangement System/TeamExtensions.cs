using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public static class TeamExtensions
    {
        public static void PrintTeamReport(this Team team)
        {
            Console.WriteLine($"\nTeam Report: {team.Name}");
            Console.WriteLine($"  Coach: {team.CoachName}");
            Console.WriteLine($"  Average Age: {team.CalculateAverageAge():F1}");
            Console.WriteLine($"  Total Goals: {team.GetTotalGoals()}");
            var top = team.GetTopScorer();
            Console.WriteLine($"  Top Scorer: {top?.Name} ({top?.Goals} goals)");
        }
    }
}
