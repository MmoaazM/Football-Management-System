using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Manangement_System
{
    public class StatsCalculator<T> where T : FootballPlayer
    {
        public int CalculateAverageGoals(List<T> players) { return 0; }
        public int CalculateAverageAge(List<T> players) { return 0; }
        public FootballPlayer GetBestPlayer(List<T> players) { return null; }
        public FootballPlayer GetWorstPlayer(List<T> players) { return null; }

    }
}
